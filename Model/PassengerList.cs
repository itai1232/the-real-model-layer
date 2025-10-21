﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PassengerList : List<Passenger>
    {
        public PassengerList() { }
        public PassengerList(IEnumerable<Passenger> list) : base(list) { }
        public PassengerList(IEnumerable<BaseEntity> list) : base(list.Cast<Passenger>().ToList()) { }
    }
}
