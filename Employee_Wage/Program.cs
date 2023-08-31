// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Use Case 1-EmployeeAttendance
using System;
namespace Employee_Wage
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            //defining const here
            int Is_Full_Time = 1;
            //creating object of Randaom class
            Random rnd = new Random();
            int empCheck=rnd.Next(0,2);
            Console.WriteLine(empCheck);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
                Console.WriteLine("Employee is absent");


        }
    }
}