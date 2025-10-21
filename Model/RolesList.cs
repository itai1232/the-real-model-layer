using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RolesList : List<Roles>
    {
        public RolesList() { }
        public RolesList(IEnumerable<Roles> list) : base(list) { }
        public RolesList(IEnumerable<BaseEntity> list) : base(list.Cast<Roles>().ToList()) { }
    }
}
