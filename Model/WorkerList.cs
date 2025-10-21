using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WorkerList : List<Worker>
    {
        public WorkerList() { }
        public WorkerList(IEnumerable<Worker> list) : base(list) { }
        public WorkerList(IEnumerable<BaseEntity> list) : base(list.Cast<Worker>().ToList()) { }
    }
}
