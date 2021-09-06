using System;
using System.Collections.Generic;
using System.Text;

namespace ArrongShop
{
  public sealed  class   CommissionEmployee : Employee
    {
        
        private decimal sellAmount;
        private decimal commissionRate;


        public CommissionEmployee(string firstName, string lastName, string nidNumber, decimal sellAmount, decimal commissionRate):base(firstName, lastName, nidNumber)
        {
           
            this.sellAmount = sellAmount;
            this.commissionRate = commissionRate;
        }

        public override decimal getEarning()
        {
            return (this.sellAmount * this.commissionRate)/100;
        }

        
    }
}
