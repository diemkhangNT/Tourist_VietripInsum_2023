﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tourist_VietripInsum_2023.DesignPattern.TemplateMethod
{
    public abstract class TemplateMethodController : Controller
    {
        public abstract string PrintRoutes();
        public abstract string PrintDIs();
        
        //template
        public string PrintInfo()
        {
            return PrintRoutes() + "\n&& " + PrintDIs();
        }
    }
}