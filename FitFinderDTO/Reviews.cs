using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFinderDTO
{
   
        public class Reviews
        {
            public int Review_Id { get; set; }
            public int Score { get; set; }
            public string Description { get; set; }
            public int Member_Id { get; set; }
            public string Product_Id { get; set; }
        }
    
}
