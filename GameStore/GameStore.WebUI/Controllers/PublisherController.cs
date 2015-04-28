﻿using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BootstrapMvcSample.Controllers;
using BootstrapSupport;
using GameStore.BLL.Interfaces;
using GameStore.BLL.Models;
using GameStore.WebUI.ViewModels;

namespace GameStore.WebUI.Controllers
{
    public class PublisherController : BootstrapBaseController
    {
        private readonly IPublisherService _publisherService;

        public PublisherController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        [HttpGet]
        [ActionName("Get")]
        public ActionResult GetAll()
        {
            var publishers = _publisherService.GetAll();
            var viewModels = Mapper.Map<IEnumerable<PublisherViewModel>>(publishers);
            return View(viewModels);
        }

        [HttpGet]
        [ActionName("New")]
        public ActionResult Add()
        {
            return View(new PublisherViewModel());
        }

        [ActionName("New")]
        [HttpPost]
        public ActionResult Add(PublisherViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var model = Mapper.Map<PublisherModel>(viewModel);
                _publisherService.Add(model);
                MessageSuccess("The publisher has been added successfully. ");
                return RedirectToAction("Get");
            }

            TempData.Add(Alerts.ERROR, "Model state is not valid.");
            return View(viewModel);
        }

        [ActionName("Details")]
        public ActionResult Details(string key)
        {
            var model = _publisherService.GetModelByCompanyName(key);
            var viewModel = Mapper.Map<PublisherViewModel>(model);
            return View(viewModel);
        }
    }
}