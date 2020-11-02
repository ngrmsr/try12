using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class HomeViewModel
    {
        public List<Ads> advertise { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
    }
    public class Ads
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public class CategoryViewModel
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
