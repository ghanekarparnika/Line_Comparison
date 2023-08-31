// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Use Case 7 - Ability to compute Employee Wage for multiple companies
using System;
namespace Employee_Wage
{
    internal class Program 
    {
        //defining const here
        const int Is_Full_Time = 1;
        const int Is_Part_Time = 2;
        const int Emp_Rate_Per_Hr = 20;
        const int Num_Of_Days = 20;
        const int Max_Num_of_Hrs = 100;

        public static void calc_EmpWage()
        {
            //variables
            int empHrs = 0, totalEmpWage = 0, MaxEmpHrs = 0, totalWorkingdays = 0;

            while (MaxEmpHrs < Max_Num_of_Hrs || totalWorkingdays < Num_Of_Days)
            {

                totalWorkingdays++;
                //creating object of Randaom class
                Random rnd = new Random();
                int empCheck = rnd.Next(0, 3);
                //Console.WriteLine("Day:"+totalWorkingdays);
                switch (empCheck)
                {
                    case Is_Full_Time:
                        Console.WriteLine("Full time Employee");
                        empHrs = 8;
                        break;
                    case Is_Part_Time:
                        Console.WriteLine("Part time Employee");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        empHrs = 0;
                        break;

                }
                MaxEmpHrs += empHrs;
                Console.WriteLine("Working Day:" + totalWorkingdays + "         Total_Hours:" + MaxEmpHrs);

            }
            totalEmpWage = MaxEmpHrs * Emp_Rate_Per_Hr;
            Console.WriteLine("Total Emp Wage:" + totalEmpWage);

        }

    
        static void Main(string[] args) 
        {
            Program.calc_EmpWage();

        }
    }
}