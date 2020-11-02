using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewComponents
{
    //public class AdsViewComponent
    //{
    //    public string Invoke()
    //    {
    //        return "this is ads";
    //    }
    //}
    public class AdsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
