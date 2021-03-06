﻿using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using GameStore.BLL.Interfaces;
using GameStore.BLL.Models;
using GameStore.DAL.Entities;
using GameStore.DAL.Interfaces;

namespace GameStore.BLL.Services
{
    public class BasketService : IBasketService
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="BasketService"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        public BasketService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddBasketItem(BasketItemModel basketItemModel)
        {
            var basketItem = Mapper.Map<BasketItem>(basketItemModel);

            if (basketItemModel.Game != null)
            {
                basketItem.Game = _unitOfWork.GameRepository.GetById(basketItemModel.GameId);
            }

            _unitOfWork.BasketItemRepository.Insert(basketItem);
            _unitOfWork.SaveChanges();
        }

        public void RemoveBasketItem(int basketItemId)
        {
            _unitOfWork.BasketItemRepository.Delete(basketItemId);
            _unitOfWork.SaveChanges();
        }

        public void UpdateBasketItem(BasketItemModel basketItemModel)
        {
            BasketItem basketItem = _unitOfWork.BasketItemRepository.GetById(basketItemModel.BasketItemId);
            Mapper.Map(basketItemModel, basketItem);

            if (basketItemModel.Game != null)
            {
                basketItem.Game = _unitOfWork.GameRepository.GetById(basketItemModel.GameId);
            }

            _unitOfWork.BasketItemRepository.Update(basketItem);
            _unitOfWork.SaveChanges();
        }

        public BasketModel GetBasketModelForUser(string sessionKey)
        {
            Basket basket = _unitOfWork.BasketRepository.Get(b => b.SessionKey == sessionKey).FirstOrDefault();

            if (basket == null)
            {
                basket = new Basket {SessionKey = sessionKey};
                _unitOfWork.BasketRepository.Insert(basket);
                _unitOfWork.SaveChanges();
            }

            var basketModel = Mapper.Map<BasketModel>(basket);
            return basketModel;
        }

        public void CleanBasketForUser(string sessionKey)
        {
            Basket basket = _unitOfWork.BasketRepository.Get(b => b.SessionKey == sessionKey).FirstOrDefault();

            if (basket == null) return;

            List<BasketItem> basketItemsToRemove = basket.BasketItems.ToList();

            foreach (BasketItem basketItem in basketItemsToRemove)
            {
                _unitOfWork.BasketItemRepository.Delete(basketItem);
            }

            _unitOfWork.BasketRepository.Delete(basket);
            _unitOfWork.SaveChanges();
        }
    }
}