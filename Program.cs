using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a program for Line Comparison");
            Console.WriteLine("Enter the coordinates"); 

            double x1, y1, x2, y2, length1;
            
            Console.WriteLine("enter x1: ");
            x1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter y1: ");
            y1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter x2: ");
            x2=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter y2: ");
            y2=Convert.ToDouble(Console.ReadLine());

            length1= Math.Sqrt(((x2-x1)*(x2-x1)) + ((y2-y1)*(y2-y1)));

            double a1, b1, a2, b2, length2;

            Console.WriteLine("enter a1: ");
            a1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter b1: ");
            b1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter a2: ");
            a2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter b2: ");
            b2 = Convert.ToDouble(Console.ReadLine());

            length2 = Math.Sqrt(((a2 - a1) * (a2 - a1)) + ((b2 - b1) * (b2 - b1)));

            if (length1.CompareTo(length2) == 0) 
            {
                Console.WriteLine("Lines are of equal length");
            }
           
            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("Line1 is bigger than Line2");
            }
            else
            {
                Console.WriteLine("Line2 is bigger than Line1");
            }
            Console.ReadLine();
        }
    }
}
