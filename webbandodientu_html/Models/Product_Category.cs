using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webbandodientu_html.Context;

namespace webbandodientu_html.Models
{
    public class Product_Category
    {
        public List<Product> ListProduct { get; set; }
        public List<Category> ListCategory { get; set; }
    }
}