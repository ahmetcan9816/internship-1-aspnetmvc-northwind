using Northwind.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Northwind.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}