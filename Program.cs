using System;
using System.Collections.Generic;

namespace ArrongShop
{
    class Program
    {
        static void Main(string[] args)
        {
          //  SalaryEmployee salaryEmployee = new SalaryEmployee("md", "sumon", "123", 5000);


          //  Console.WriteLine(salaryEmployee.getFullInformation());


            // CommissionEmployee commissionEmployee = new CommissionEmployee("md", "sumon", "123", 500000, 5);
            //
            // Console.WriteLine(commissionEmployee.getFullInformation());


            Employee salaryEmployee = new SalaryEmployee("md", "sumon", "123", 5000);
         //   Console.WriteLine(salaryEmployee.getFullInformation());



            Employee commissionEmployee = new CommissionEmployee("md", "sumon", "123", 500000, 5);

       //     Console.WriteLine(commissionEmployee.getFullInformation());


            var employee = new List<Employee>();

            employee.Add(salaryEmployee);
            employee.Add(commissionEmployee);

            foreach (var employee1 in employee)
            {
                Console.WriteLine(employee1.getEarning());
            }


            int number1 = 50;
            decimal number2 = number1;

            int number3 = (int) number2;


            Console.ReadKey();

        }
    }
}
