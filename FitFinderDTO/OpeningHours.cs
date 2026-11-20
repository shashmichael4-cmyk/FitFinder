using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFinderDTO
{
   
        public class OpeningHours
        {
            public int OpeningHours_Id { get; set; }
            public string Open_Time { get; set; }
            public string Close_Time { get; set; }
            public string Day { get; set; }
            public int Gym_Id { get; set; }
    }
    
}
