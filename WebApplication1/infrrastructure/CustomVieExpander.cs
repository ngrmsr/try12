using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.infrrastructure
{
    public class CustomVieExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            if (DateTime.Parse(context.Values["time"]) >= DateTime.Parse("17:30"))
            {
                foreach (var item in viewLocations)
                {
                    yield return item;
                }
                yield return "/Views/Shared/Night/{0}.cshtml";
            }
            else
            {
                foreach (var item in viewLocations)
                {
                    yield return item;
                }
                yield return "/Views/Shared/Day/{0}.cshtml";
            }
            //foreach (var item in viewLocations)
            //{
            //    yield return item;
            //}
            //yield return "/view/night/{1}/{0}.cshtml";
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            context.Values.Add("time", DateTime.Now.TimeOfDay.ToString());
        }
    }
}
