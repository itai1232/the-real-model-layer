using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class InvitationsList : List<Invitations>
    {
        public InvitationsList() { }
        public InvitationsList(IEnumerable<Invitations> list) : base(list) { }
        public InvitationsList(IEnumerable<BaseEntity> list) : base(list.Cast<Invitations>().ToList()) { }
    }
}
