using System;
using System.Collections.Generic;
using Employee.Entities;
using System.Globalization;
namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> emp = new List<Employees>();

            Console.WriteLine("Enter the number of employee");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #{0} data: ", i);
                Console.Write("Outsoucer (y/n) ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Enter the adicional Charge: ");
                    double adicionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.Add(new OutsourceEmployee(name, hours, valuePerHour, adicionalCharge));
                }
                else
                {
                    emp.Add(new Employees(name, hours, valuePerHour));
                }
             
            }

            Console.WriteLine();
            Console.WriteLine("Payment: ");

            foreach (Employees employees in emp)
            {
                Console.WriteLine("Name:{0}", employees.Name);
                Console.WriteLine("Payment:{0}", employees.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
