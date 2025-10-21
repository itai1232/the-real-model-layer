using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FlightCompany:BaseEntity
    {
        private string flightCompanyName;
        public string FlightCompanyName { get => flightCompanyName; set => flightCompanyName = value; }
    }
}
