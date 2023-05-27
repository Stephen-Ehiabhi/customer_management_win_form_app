using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Person
    {
        public Person()
        {
        }
        protected string name, lastname, email, address;
        protected int phonenumber;
        private Person(string name,string lastname,string email,string address,int phonenumber)
        {
            this.name = name;
            this.lastname = lastname;
            this.email = email;
            this.address = address;
            this.phonenumber = phonenumber;
        }


    }
}
