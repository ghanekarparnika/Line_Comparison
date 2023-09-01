// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Use Case1---->As a fan of geometry, I want to model a line based on a point consisting of (x, y) co-ordinates using the Cartesian system,
//So that I can calculate its length
//A Length as 2 Points (x1, y1) and(x2, y2)
//Length of a Line = sqrt( (x2 - x1) ^2 + (y2 - y1) ^ 2)


internal class Program 
{
    static double CalculateLength1(double x1, double y1, double x2, double y2)
    {
        double length1= Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 -y1, 2));
        return length1;

    }

    static double CalculateLength2(double p1, double k1, double p2, double k2)
    {
        double length2 = Math.Sqrt(Math.Pow(p2 - p1, 2) + Math.Pow(k2 - k1, 2));
        return length2;

    }

    static void Is_Equal(double l1, double l2)
    {
        if (l1 == l2)
        {
            Console.WriteLine("Two Lines are equal");
        }
        else
            Console.WriteLine("Lines are not Equal");

    }
    static void Main(string[] args)
    {
        Random random = new Random();
        double x1 = random.Next(0,9);
        double y1 = random.Next(0,9);
        double x2 = random.Next(0,9);
        double y2 = random.Next(0,9);


        double p1 = random.Next(0, 9);
        double k1 = random.Next(0, 9);
        double p2 = random.Next(0, 9);
        double k2 = random.Next(0, 9);

        //double x1 = 1, x2 = 2, y1 = 3 ,y2 = 6;
        //double p1 = 1, p2 = 2, k1 = 3, k2 = 6;

        double length1 = CalculateLength1(x1, y1, x2, y2);
        double length2 = CalculateLength2(p1, k1, p2, k2);
        Console.WriteLine("Length of line1:"+length1+"      "+ "Length of line1:" + length2);
        Is_Equal(length1, length2);
        
    }
}
