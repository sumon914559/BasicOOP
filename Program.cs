using System;

namespace ArrongShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryEmployee salaryEmployee = new SalaryEmployee("md", "sumon", "123", 5000);


            Console.WriteLine(salaryEmployee.getFullInformation());


            CommissionEmployee commissionEmployee = new CommissionEmployee("md", "sumon", "123", 500000, 5);

            Console.WriteLine(commissionEmployee.getFullInformation());


            

            Console.ReadKey();

        }
    }
}
