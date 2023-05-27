using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1
{
    class Customer : Person
    {
        private string id, accountnumber, plan;
        private int Balance, saving;

        protected internal Customer(string name, string lastname, string email, string address, int phonenumber, int Balance, string accountnumber, string id, string plan,int saving)
        {
            this.name = name;
            this.lastname = lastname;
            this.email = email;
            this.address = address;
            this.phonenumber = phonenumber;
            this.Balance = Balance;
            this.accountnumber = accountnumber;
            this.id = id;
            this.plan = plan;
            this.saving = saving;
        }
        public string PrintData()
        {
            return $"{this.name}|{this.lastname}|{this.email}|{this.address}|{this.phonenumber}|{this.Balance}|{this.accountnumber}|{this.id}|{this.plan}|{this.saving}\n";

        }
        public string UpdateData()
        {
            return $"{this.name}|{this.lastname}|{this.email}|{this.address}|{this.phonenumber}|{this.Balance}|{this.accountnumber}|{this.id}|{this.plan}|{this.saving}";

        }

        //For Read Only 
        public string Name{get{return this.name;}}        
        public string LName { get { return this.lastname; } set { this.lastname = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public string Address { get { return this.address; } set { this.address = value; } }
        public int PhoneNumber { get { return this.phonenumber; } set { this.phonenumber = value; } }
        public int balance { get { return this.Balance; } }
        public string AccNumber { get { return this.accountnumber; } }
        public string ID { get { return this.id; } }
        public string Plan { get { return this.plan; } }
        public int Saving { get { return this.saving; } }

        //For Edit
        public string SetName { set { this.name = value; } }
        public string SetLName {set { this.lastname = value; } }
        public string SetEmail {set { this.email = value; } }
        public string SetAddress { set { this.address = value; } }
        public int SetPhoneNumber {set { this.phonenumber = value; } }
        public int Setbalance {set { this.Balance = value; } }
        public string SetPlan { set { this.plan = value; } }
        public int SetSaving { set { this.saving = value; } }
        /* public string ChangeBalance { }*/
    }
}
