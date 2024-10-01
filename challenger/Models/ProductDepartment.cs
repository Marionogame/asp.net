using challenger.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace challenger.Models
{
    public class ProductDepartment
    {
      
        public Product ListProduct { get; set; }

        public IEnumerable<SelectListItem> ListDepartment { get; set; }

        public ProductDepartment()
        {
            ListDepartment = new List<SelectListItem>();
        }
    }
}