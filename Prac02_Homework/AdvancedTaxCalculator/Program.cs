using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaxCalculator
{
    class Program
    {
        static int average_Age(string[] args)
        {
            int age=0;
            int counter = 1;
            
            while(counter<args.Length)
            {
                
                age = age + Convert.ToInt32(args[counter]);
                counter = counter + 2;

            }
            return age;
        }
        static double monthlySalary(string[] args)
        {
            double salary = 0;
            int count = 0;
            while(count<args.Length)
            {
                salary = salary + Convert.ToDouble(args[count]);
                count = count + 2;

            }
            return salary;
        }
        static double averageTax(string[] args)
        {
            double monthlySalary = 0;
            int monthlyTax = 0;
            int count = 0;
            int counter = 1;
            double total = 0;
            int age = 0;

            while (count < args.Length)
            {
                age = Convert.ToInt32(args[counter]);
                monthlySalary = Convert.ToDouble(args[count]);


                if (monthlySalary <= 4999)
                {
                    monthlyTax = 0;
                }
                else if (monthlySalary >= 5000 && monthlySalary <= 6499)
                {
                    if (age <= 65)
                    {
                        monthlyTax = 13;

                    }

                }
                else if (monthlySalary >= 6500 && monthlySalary <= 7799)
                {
                    if (age <= 65)
                    {
                        monthlyTax = 250;


                    }

                }
                else if (monthlySalary >= 7800 && monthlySalary <= 9999)
                {
                    if (age <= 65)
                    {
                        monthlyTax = 620;

                    }

                }
                else if (monthlySalary >= 10000 && monthlySalary <= 13499)
                {
                    if (age <= 65)
                    {
                        monthlyTax = 1200;

                    }
                    else if (age >= 65 && age <= 75)
                    {
                        monthlyTax = 600;

                    }
                    else
                    {
                        monthlyTax = 400;

                    }

                }
                else if (monthlySalary >= 13500 && monthlySalary <= 17899)
                {
                    if (age <= 65)
                    {
                        monthlyTax = 2100;


                    }
                    else if (age >= 65 && age <= 75)
                    {
                        monthlyTax = 1500;


                    }
                    else
                    {
                        monthlyTax = 1200;

                    }


                }
                else if (monthlySalary >= 17900 && monthlySalary <= 19999)
                {
                    if (age <= 65)
                    {
                        monthlyTax = 2700;


                    }
                    else if (age >= 65 && age <= 75)
                    {
                        monthlyTax = 2000;


                    }
                    else
                    {
                        monthlyTax = 1800;

                    }

                }
                else if (monthlySalary >= 20000 && monthlySalary <= 39999)
                {
                    if (age <= 65)
                    {
                        monthlyTax = 8000;


                    }
                    else if (age >= 65 && age <= 75)
                    {
                        monthlyTax = 7500;


                    }
                    else
                    {
                        monthlyTax = 7300;

                    }


                }
                else if (monthlySalary >= 40000 && monthlySalary <= 59999)
                {
                    if (age <= 65)
                    {
                        monthlyTax = 16000;


                    }
                    else if (age >= 65 && age <= 75)
                    {
                        monthlyTax = 15600;


                    }
                    else
                    {
                        monthlyTax = 15400;

                    }

                }
                else
                {
                    if (age <= 65)
                    {
                        monthlyTax = 20000;


                    }
                    else if (age >= 65 && age <= 75)
                    {
                        monthlyTax = 17050;


                    }
                    else
                    {
                        monthlyTax = 17000;

                    }

                }


           
                count = count + 2;
                counter = counter + 2;
                total = total + monthlyTax;
            }


            return total;

        }

        


        static void Main(string[] args)
        {
          
            int age = average_Age(args);
            int average = age / (args.Length/2);

            double salary = monthlySalary(args);
            double average2 = salary / (args.Length/2);

            double tax = averageTax(args);
            double average_T = tax / (args.Length / 2);

            Console.WriteLine("Average age of taxpayers was " + average);
            Console.WriteLine("Average monthly salary of taxpayers was " +"R"+ Math.Round(average2,2)); //this give the average monthly salary 
            Console.WriteLine("Average tax of all taxpayers was " +"R"+ Math.Round(average_T, 2));
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue ... ");
            
            Console.ReadLine();

           

        }
    }
}
