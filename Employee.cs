using System;
using System.Collections.Generic;
using System.Text;

namespace ArrongShop
{
    public abstract class Employee
    {
        private string firstName;
        private string lastName;
        private string nidNumber;


        public abstract decimal getEarning();


        public Employee(string firstName, string lastName, string nidNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.nidNumber = nidNumber;
        }

        protected string getFullName()
        {
            return this.firstName + " " + this.lastName;
        }

        public string getFullInformation()
        {
            return "your full name is : " + this.getFullName() + " \n Total earning: " +
                   this.getEarning();
        }
    }
}