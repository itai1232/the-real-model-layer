﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Countries:BaseEntity
    {
        private string countryName;
        public string CountryName { get => countryName; set => countryName = value; }
    }
}
