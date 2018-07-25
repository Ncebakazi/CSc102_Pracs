using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthlyTax = 0;

            Console.WriteLine("Please enter your monthly salary: ");
            string salary = Console.ReadLine();
            bool found=Int32.TryParse(salary, out int monthlySalary);

            Console.WriteLine("Please enter your age: ");
            string age = Console.ReadLine();
            bool found2= Int32.TryParse(age, out int Age);

            
           
            if (found == true && found2==true) //checks if the user entered both inputs as numbers 
            {
                if (monthlySalary <= 4999)
                {
                    
                }
                else if (monthlySalary >= 5000 && monthlySalary <= 6499)
                {
                    if (Age <= 65)
                    {
                        monthlyTax = 13;
                     
                    }
                   
                }
                else if (monthlySalary >= 6500 && monthlySalary <= 7799)
                {
                    if (Age <= 65)
                    {
                        monthlyTax = 250;
                        

                    }
                   
                }
                else if (monthlySalary >= 7800 && monthlySalary <= 9999)
                {
                    if (Age <= 65)
                    {
                        monthlyTax = 620;
                        
                    }
                   
                }
                else if (monthlySalary >= 10000 && monthlySalary <= 13499)
                {
                    if (Age <= 65)
                    {
                        monthlyTax = 1200;
                        
                    }
                    else if(Age >=65 && Age <=75)
                    {
                        monthlyTax = 600;
                       
                    }
                    else
                    {
                        monthlyTax = 400;
                        
                    }
                    
                }
                else if(monthlySalary >= 13500 && monthlySalary <= 17899)
                {
                    if (Age <= 65)
                    {
                        monthlyTax = 2100;
                        

                    }
                    else if (Age >= 65 && Age <= 75)
                    {
                        monthlyTax = 1500;
                        

                    }
                    else
                    {
                        monthlyTax = 1200;
                        
                    }


                }
                else if(monthlySalary >= 17900 && monthlySalary <= 19999)
                {
                    if (Age <= 65)
                    {
                        monthlyTax = 2700;
                        

                    }
                    else if (Age >= 65 && Age <= 75)
                    {
                        monthlyTax = 2000;
                        

                    }
                    else
                    {
                        monthlyTax = 1800;
                       
                    }

                }
                else if(monthlySalary >= 20000 && monthlySalary <= 39999)
                {
                    if (Age <= 65)
                    {
                        monthlyTax = 8000;
                        

                    }
                    else if (Age >= 65 && Age <= 75)
                    {
                        monthlyTax = 7500;
                        

                    }
                    else
                    {
                        monthlyTax = 7300;
                        
                    }


                }
                else if(monthlySalary >= 40000 && monthlySalary <= 59999)
                {
                    if (Age <= 65)
                    {
                        monthlyTax = 16000;
                       

                    }
                    else if (Age >= 65 && Age <= 75)
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
                    if (Age <= 65)
                    {
                        monthlyTax = 20000;
                        

                    }
                    else if (Age >= 65 && Age <= 75)
                    {
                        monthlyTax = 17050;
                        

                    }
                    else
                    {
                        monthlyTax = 17000;
                        
                    }

                }


                Console.WriteLine("Your monthly tax is: " + monthlyTax);
                Console.WriteLine("Press ENTER to continue ... " );
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
            }


        }
    }
}
