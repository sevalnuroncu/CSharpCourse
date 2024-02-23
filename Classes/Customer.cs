using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //field
        //private string FistName;
        private string _firstName;

        //property
        //auto prpperty
        public int  Id { get; set; }
        public string FirstName
        {
            get { return "Mrs."+ _firstName; }
            set { _firstName = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
