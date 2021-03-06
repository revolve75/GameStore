﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using GameStore.BLL.Enums;
using GameStore.BLL.Interfaces;
using GameStore.BLL.Models;
using GameStore.WebUI.Filters;
using GameStore.WebUI.Helpers;
using GameStore.WebUI.Security;
using GameStore.WebUI.ViewModels;

namespace GameStore.WebUI.Controllers
{
    [ExceptionLoggingFilter]
    [PerformanceLoggingFilter]
    public class CommentController : BaseController
    {
        private readonly IGameService _gameService;
        private readonly ICommentService _commentService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentController"/> class.
        /// </summary>
        /// <param name="gameService">The game service.</param>
        /// <param name="commentService">The comment service.</param>
        public CommentController(
            IGameService gameService,
            ICommentService commentService)
        {
            _gameService = gameService;
            _commentService = commentService;
        }

        /// <summary>
        /// Gets all comments for a game specified by the key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("Comments")]
        public ActionResult GetCommentsForGame(string key)
        {
            GameModel gameModel = _gameService.GetGameModelByKey(key);
            IEnumerable<CommentModel> commentModels = gameModel.Comments;
            var commentViewModels = Mapper.Map<IEnumerable<CommentViewModel>>(commentModels);
            return View(commentViewModels);
        }

        /// <summary>
        /// Adds the comment for game specified by the key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="commentViewModel">The comment view model.</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("NewComment")]
        public ActionResult AddCommentForGame(string key, CommentViewModel commentViewModel)
        {
            var commentModel = Mapper.Map<CommentModel>(commentViewModel);
            _commentService.Add(commentModel, key);
            MessageSuccess("The comment has been added successfully!");
            return RedirectToAction("Comments", new {key});
        }

        /// <summary>
        /// Removes the comment.
        /// </summary>
        /// <param name="id">The comment identifier.</param>
        /// <returns></returns>
        [ActionName("Remove")]
        [CustomAuthorize(Roles = "Admin, Moderator")]
        public ActionResult RemoveComment(int id)
        {
            _commentService.Remove(id);
            MessageSuccess("The comment has been removed successfully!");
            return RedirectToAction("Comments");
        }

        [ActionName("Ban")]
        [HttpGet]
        [CustomAuthorize(Roles = "Admin, Moderator")]
        public ActionResult Ban()
        {
            var banViewModel = new BanViewModel();
            return View(banViewModel);
        }

        [ActionName("Ban")]
        [HttpPost]
        [CustomAuthorize(Roles = "Admin, Moderator")]
        public ActionResult Ban(BanViewModel banViewModel)
        {
            string message = String.Format("The user was banned on the next period: {0}.",
                EnumHelper<BanPeriod>.GetEnumDescription(banViewModel.BanPeriod.ToString()));
            MessageAttention(message);
            return RedirectToAction("Get", "Game");
        }
    }
}