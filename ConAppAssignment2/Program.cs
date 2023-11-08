using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter employee ID: ");
                int employeeID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter employee name: ");
                string employeeName = Console.ReadLine();

                Console.Write("Enter employee gender (M/F): ");
                string employeeGender = Console.ReadLine();

                Console.Write("Enter employee salary: ");
                double employeeSalary = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter employee date of joining (DD-MM-YYYY): ");
                DateTime employeeDOJ = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("\nEmployee Details:");
                Console.WriteLine("------------------------");
                Console.WriteLine("Employee ID: " + employeeID);
                Console.WriteLine("Employee Name: " + employeeName);
                Console.WriteLine("Employee Gender: " + employeeGender);
                Console.WriteLine("Employee Salary: " + employeeSalary);
                Console.WriteLine("Employee Date of Joining: " + employeeDOJ);

                // Calculate tax
                double taxPercentage;
                if (employeeSalary > 90000)
                {
                    taxPercentage = 0.3;
                }
                else
                {
                    taxPercentage = 0.15;
                }

                double taxAmount = employeeSalary * taxPercentage;

                // Display tax message
                Console.WriteLine("\nTax Information:");
                Console.WriteLine("------------------------");
                Console.WriteLine("Tax Percentage: " + taxPercentage * 100 + "%");
                Console.WriteLine("Tax Amount: " + taxAmount);

                Console.WriteLine("\nPress any key to exit.");
                Console.ReadKey();
            }
        }
    }
    

