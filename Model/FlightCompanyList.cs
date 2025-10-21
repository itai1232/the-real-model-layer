using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FlightCompanyList : List<FlightCompany>
    {
        public FlightCompanyList() { }
        public FlightCompanyList(IEnumerable<FlightCompany> list) : base(list) { }
        public FlightCompanyList(IEnumerable<BaseEntity> list) : base(list.Cast<FlightCompany>().ToList()) { }
    }
}
