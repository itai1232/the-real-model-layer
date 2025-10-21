using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Flight:BaseEntity
    {
        private DateTime takeOffTime;
        public DateTime TakeOffTime { get=>takeOffTime; set => takeOffTime = value; }
        private Planes planeType;
        public Planes PlaneType { get => planeType; set => planeType = value; }
        private DateTime arrivalTime;
        public DateTime ArrivalTime { get => arrivalTime; set => arrivalTime = value; }
        private Airports destinationAirport;
        public Airports DestinationAirport { get => destinationAirport; set => destinationAirport = value; }
        private Airports currentAirport;
        public Airports CurrentAirport { get => currentAirport; set => currentAirport = value; }
        private double price;
        public double Price { get => price; set => price = value; }

    }
}
