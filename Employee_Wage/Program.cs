// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Use Case 1-EmployeeAttendance
//Use Case 2- Calculate Epmloyee Daily Wage
//Use Case 3-Adding Part_Time_Employee and calculating Wage 
using System;
namespace Employee_Wage
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            //defining const here
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int Emp_Rate_Per_Hr = 20;
            //variables
            int empHrs = 0, empWage = 0;
            //creating object of Randaom class
            Random rnd = new Random();
            int empCheck=rnd.Next(0,3);
            Console.WriteLine(empCheck);
           

            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Full Time Employee");
                empHrs = 8;
            }
            else if (empCheck== Is_Part_Time) 
            {
                Console.WriteLine("Part Time Employee");
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
               

            empWage = empHrs * Emp_Rate_Per_Hr;
            Console.WriteLine("Employee Wage: "+empWage);


        }
    }
}