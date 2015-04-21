﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BootstrapMvcSample.Controllers;
using GameStore.BLL.Interfaces;
using GameStore.BLL.Models;
using GameStore.WebUI.Filters;

namespace GameStore.WebUI.Controllers
{
    [ExceptionLoggingFilter]
    [PerformanceLoggingFilter]
    public class CommentController : BootstrapBaseController
    {
        private readonly IGameService _gameService;
        private readonly ICommentService _commentService;

        public CommentController(
            IGameService gameService,
            ICommentService commentService)
        {
            _gameService = gameService;
            _commentService = commentService;
        }

        [HttpGet]
        [ActionName("Comments")]
        public ActionResult GetCommentsForGame(string key)
        {
            GameModel gameModel = _gameService.GetGameModelByKey(key);
            ICollection<CommentModel> commentModels = gameModel.Comments;
            return View(commentModels);
        }

        [HttpPost]
        [ActionName("NewComment")]
        public ActionResult AddCommentForGame(string key, CommentModel commentModel)
        {
            _commentService.Add(commentModel, key);
            MessageSuccess("The comment has been added successfully!");
            return RedirectToAction("Comments", new { key = key });
        }
    }
}
