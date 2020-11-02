using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.infrrastructure
{
    public abstract class CustomRazorPage<TModel>:RazorPage<TModel>
    {
        public string Print()
        {
            return "this is test";
        }
    }
}
