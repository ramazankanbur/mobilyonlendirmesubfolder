﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobilYonlendirmeSubfolder
{
    public class MobileRedirectAttribute : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var path = filterContext.HttpContext.Request.Url.AbsolutePath;
            if (filterContext.HttpContext.Request.Browser.IsMobileDevice)
            {
                filterContext.HttpContext.Response.Redirect("~/mobile" + path);
            }
        }
    }
}