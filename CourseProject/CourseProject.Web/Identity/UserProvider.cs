﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using CourseProject.Web.Identity.Contracts;

namespace CourseProject.Web.Identity
{
    public class UserProvider : IUserProvider
    {
        private readonly HttpContext httpContext;

        //public UserProvider(HttpContext httpContext)
        //{
        //    if(httpContext == null)
        //    {
        //        throw new ArgumentNullException("httpContext");
        //    }

        //    this.httpContext = httpContext;
        //}

        public string GetUserId()
        {
            return HttpContext.Current.User.Identity.GetUserId();
        }

        public string GetUsername()
        {
            return HttpContext.Current.User.Identity.GetUserName();
        }
    }
}