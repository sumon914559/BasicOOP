using System;
using System.Collections.Generic;
using System.Text;

namespace ArrongShop
{
    public class SalaryEmployee : Employee
    {
        
        private decimal monthlySalary;


      

        public SalaryEmployee(string firstName, string lastName, string nidNumber, decimal monthlySalary):base(firstName, lastName, nidNumber)
        {
           
            this.monthlySalary = monthlySalary;
        }

       


        public override decimal getEarning()
        {
            return this.monthlySalary;
        }

        

       




    }
}