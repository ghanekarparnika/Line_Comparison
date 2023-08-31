// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Use Case 1-EmployeeAttendance
//Use Case 2- Calculate Epmloyee Daily Wage
//Use Case 3-Adding Part_Time_Employee and calculating Wage 
//Use Case 4-Solving using switch case statement
//Use Case 5-Calculating Wages for 20 workong days in a month
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
        static void Main(string[] args) 
        {
            //variables
            int empHrs = 0, empWage = 0,totalEmpWage=0;

            for (int day=1;day<=Num_Of_Days;day++) {
                //creating object of Randaom class
                Random rnd = new Random();
                int empCheck = rnd.Next(0, 3);
                Console.WriteLine("Day:"+day);
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
                        empHrs = 0;
                        break;

                }

                empWage = empHrs * Emp_Rate_Per_Hr;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage: " + empWage);
            }
            Console.WriteLine("Total Emp Wage:"+totalEmpWage);

        }
    }
}