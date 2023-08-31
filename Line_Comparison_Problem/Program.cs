// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Use Case1---->As a fan of geometry, I want to model a line based on a point consisting of (x, y) co-ordinates using the Cartesian system,
//So that I can calculate its length
//A Length as 2 Points (x1, y1) and(x2, y2)
//Length of a Line = sqrt( (x2 - x1) ^2 + (y2 - y1) ^ 2)


internal class Program 
{
    static double CalculateLength(double x1, double y1, double x2, double y2)
    {
        double length= Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 -y1, 2));
        return length;

    }
    static void Main(string[] args)
    {
        Random random = new Random();
        double x1 = random.Next(0,9);
        double y1 = random.Next(0,9);
        double x2 = random.Next(0,9);
        double y2 = random.Next(0,9);
        //double x1=1,x2=2,y1=3,y2=6;
        Console.WriteLine(x1);
        Console.WriteLine(y1);
        Console.WriteLine(x2);
        Console.WriteLine(y2);
        double length = CalculateLength(x1, y1, x2, y2);
        Console.WriteLine("Length of line:"+length);
    }
}
