using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MakeCompany:BaseEntity
    {
        private string makeCompanyName;
        public string MakeCompanyName { get => makeCompanyName; set => makeCompanyName = value; }
    }
}
