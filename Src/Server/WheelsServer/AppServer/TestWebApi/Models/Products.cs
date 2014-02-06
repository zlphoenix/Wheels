using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApi.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}