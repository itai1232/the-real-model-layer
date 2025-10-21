using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Planes:BaseEntity
    {
        private string numOfSeats;
        public string NumOfSeats { get => numOfSeats; set => numOfSeats = value; }
        private DateTime makeDate;
        public DateTime MakeDate { get => makeDate; set => makeDate = value; }
        private MakeCompany planesMakeCompany;
        private FlightCompany planesFlightCompany;
        public MakeCompany PlanesMakeCompany { get => planesMakeCompany; set => planesMakeCompany = value; }
        public FlightCompany PlanesFlightCompany { get => planesFlightCompany; set => planesFlightCompany = value; }
        private bool isPlaneActive;
        public bool IsPlaneActive { get => isPlaneActive; set => isPlaneActive = value; }

    }
}
