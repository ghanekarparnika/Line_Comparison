// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace Employee_Wage
{
    internal class Program
    {
        const int Is_Part_Time = 1;
        const int Is_Full_Time = 2;
        const int Emp_Rate_Per_Hour = 20;
        const int Num_of_Working_Days = 20;
        const int Max_Num_of_Working_Hours = 100;
        static void Main(string[] args)
        {
           //variables
           
            //int empHrs = 0;
            //int empWage =0;
            
           int Total_Wage = 0;
            // Random random = new Random();
            //int empCheck = random.Next(0, 3);
            /*if (empCheck == Is_Part_Time)
             {
                 empHrs = 4;
             }
             else if (empCheck == Is_Full_Time)
             {
                 empHrs = 8;
             }
             else 
             {
                 empHrs = 0;
             }*/

            /* for (int i = 1; i <= Num_of_Working_Days; i++)
             {

                 int empHrs = 0;
                 int empWage = 0;

                // int Total_Wage = 0;
                 Random random = new Random();
                 int empCheck = random.Next(0, 3);

                 switch (empCheck)

                 {
                     case Is_Part_Time:
                         empHrs = 4;
                         break;
                     case Is_Full_Time:
                         empHrs = 8;
                         break;
                     default:
                         empHrs = 0;
                         break;

                 }

                 empWage = empHrs * Emp_Rate_Per_Hour;
                 Total_Wage += empHrs;
                 Console.WriteLine("Employee wage :" + empWage);


             }*/
            // Console.WriteLine("Total wage :" + Total_Wage * Emp_Rate_Per_Hour);


            int total_emp_hrs=0, emp_days=0,  empHrs = 0; ;
            while (total_emp_hrs <= Max_Num_of_Working_Hours && emp_days < Num_of_Working_Days) 
            {
                emp_days++;

               
         
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)

                {
                    case Is_Part_Time:
                        empHrs = 4;
                        break;
                    case Is_Full_Time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                total_emp_hrs += empHrs;
                
                Console.WriteLine("Day:"+emp_days+"   "+"Emp hrs:"+empHrs);
            }
            Total_Wage += total_emp_hrs* Emp_Rate_Per_Hour;
            Console.WriteLine("Total wage :" + Total_Wage );

        }



    }
}