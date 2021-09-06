using System;
using System.Collections.Generic;
using System.Text;

namespace ArrongShop
{
   public interface ICalculator
   {
       decimal add(int x, int y);
       decimal subtract(int x, int y);
       decimal multiply(int x, int y);
       decimal divide(int x, int y);

       
   }

   public class Calculator : ICalculator
   {
       public decimal add(int x, int y)
       {
           throw new NotImplementedException();
       }

       public decimal subtract(int x, int y)
       {
           throw new NotImplementedException();
       }

       public decimal multiply(int x, int y)
       {
           throw new NotImplementedException();
       }

       public decimal divide(int x, int y)
       {
           throw new NotImplementedException();
       }
   }
}
