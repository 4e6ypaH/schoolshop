using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Models;
using System;
using System.Collections.Generic;

namespace Shop.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public List<SelectListItem> Categories { get; set; }      
    }
}
