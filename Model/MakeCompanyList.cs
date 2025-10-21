using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MakeCompanyList : List<MakeCompany>
    {
        public MakeCompanyList() { }
        public MakeCompanyList(IEnumerable<MakeCompany> list) : base(list) { }
        public MakeCompanyList(IEnumerable<BaseEntity> list) : base(list.Cast<MakeCompany>().ToList()) { }
    }
}
