using System.ComponentModel.DataAnnotations;

namespace FitFinderDTO
{
    public class Gym
    {

        public int Gym_id { get; set; }

        [Required(ErrorMessage = "Write City please")]
        public int City_Id { get; set; }
        public int Gym_raiting { get; set; }
        public string Gym_address { get; set; }
        public string Gym_price { get; set; }


    }
}
