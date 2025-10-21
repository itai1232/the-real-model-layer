using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Person:BaseEntity
    {
        private string firstName;
        public string FirstName { get => firstName; set => firstName = value; }
        private string lastName;
        public string LastName { get => lastName; set => lastName = value; }
        private string telephone;
        public string Telephone { get => telephone; set => telephone = value; }
        private string email;
        public string Email { get => email; set => email = value; }
        private Countries personCountry;
        public Countries PersonCountry { get => personCountry; set => personCountry = value; }
    }
}
