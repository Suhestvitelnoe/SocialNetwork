﻿#region

using System;
using System.Web.Mvc;
using SocialNetwork.Core.Models;
using SocialNetwork.Web.Auth;

#endregion

namespace SocialNetwork.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        /// <summary>
        ///     Обьект авторизации
        /// </summary>
        public IAuthentication Auth { get; set; }

        /// <summary>
        ///     Текущий пользователь
        /// </summary>
        public User CurrentUser
        {
            get { return ((IUserProvider) Auth.CurrentUser.Identity).User; }
        }
    }
}