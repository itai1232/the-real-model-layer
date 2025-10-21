using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Airports:BaseEntity
    {
        private string airportName;
        public string AirportName { get=>airportName; set => airportName = value; }
        private Countries airportCountry;
        public Countries AirPortCountry { get => airportCountry; set => airportCountry = value; }
    }
}
