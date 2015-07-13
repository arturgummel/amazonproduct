using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonProducts.Models
{
    public class Product
    {
        public String Title { get; set; }
        public String DetailPageLink { get; set; }
        public Nullable<double> LowestNewPrice { get; set; }
    }
}