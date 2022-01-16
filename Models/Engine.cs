using System.Collections.Generic;

namespace CarEngines
{
    public class Engine
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int Capacity_ccm { get; set; }
        
        
        
        public List<Car> CarsList { get; set; }
    }
}
