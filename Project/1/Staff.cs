using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
    {
    class Staff : Person
        {
        private string id, role;
        private int hours, salary_p_h, contact, balance;

        protected internal Staff(string id, string name, string lastname, string email, int contact, string address, string role,int hours,int salary_p_h, int balance){
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.email = email;
            this.contact = contact;
            this.address = address;
            this.role = role;
            this.hours = hours;
            this.salary_p_h = salary_p_h;
            this.balance = balance;
        }

        //For Read Only 
        public string ID { get { return this.id; } }
        public string Name { get { return this.name; } }
        public string LName { get { return this.lastname; } set { this.lastname = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public string Address { get { return this.address; } set { this.address = value; } }
        public int Contact { get { return this.contact; } set { this.contact = value; } }
        public int Balance { get { return this.balance; } }
        public string Role { get { return this.role; } }
        public int Hours { get { return this.hours; } }
        public int Salary_p_h { get { return this.salary_p_h; } }



        //For update Only 
        public string SetID { set { this.id = value; } }
        public string SetName { set { this.name = value; } }
        public int SetBalance { set { this.balance = value; } }
        public string SetRole { set { this.role = value; } }
        public int SetHours { set { this.hours = value; } }
        public int SetSalary_p_h { set { this.salary_p_h = value; } }
       

        public string PrintStaffData ( )
        {
            return $"{this.id}|{this.name}|{this.lastname}|{this.email}|{this.contact}|{this.address}|{this.role}|{this.hours}|{this.salary_p_h}|{this.balance}|\n";
        }
        public string UpdateStaffData ( )
        {
            return $"{this.id}|{this.name}|{this.lastname}|{this.email}|{this.contact}|{this.address}|{this.role}|{this.hours}|{this.salary_p_h}|{this.balance}|";
        }

    }
}
