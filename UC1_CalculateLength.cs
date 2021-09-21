using System;
using System.Collections.Generic;
using System.Text;

namespace DAY3_Line_Comparison
{
    class UC1_CalculateLength
    {
        public static void Line1Length()
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Enter number 1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 4");
            y2 = Convert.ToInt32(Console.ReadLine());
            float length;
            length = (float)(Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2))));
            Console.WriteLine("Length of the line is: " + length);
        }
    }
}

