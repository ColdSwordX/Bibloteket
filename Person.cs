using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteket
{
    public class Person
    {
        private string navn;
        private string email;

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }


    }
}
