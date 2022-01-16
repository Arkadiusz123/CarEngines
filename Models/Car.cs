using System.ComponentModel.DataAnnotations;

namespace CarEngines
{
    public class Car
    {
        public int CarId { get; set; }
        public string Car_Brand { get; set; }
        public string Model { get; set; }
        public decimal? Fuel_Consumption { get; set; }
        public int? StartOfProduction { get; set; }
        public int? EndOfProduction { get; set; }
        public string Power_HP { get; set; }
        public string Torque_Nm { get; set; }
        public decimal? Acceleration_0_100 { get; set; }
        public decimal? MaxSpeed_KM_H { get; set; }
        public int? AveragePrice_PLN { get; set; }
        public string OtomotoLink { get; set; }




        //Relations properties
        public Engine Engine { get; set; }
        [Required]
        public int? EngineId { get; set; }
       
    }
}
