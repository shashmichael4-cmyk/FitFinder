using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFinderDTO
{
   public class Product
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public int Product_Price { get; set; }
        public int Shop_Id { get; set; }
        public int Order_Id { get; set; }
    }
}
