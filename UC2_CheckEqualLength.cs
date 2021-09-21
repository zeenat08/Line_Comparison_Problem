using System;
using System.Collections.Generic;
using System.Text;

namespace DAY3_Line_Comparison
{
    class UC2_CheckEqualLength
    {
        public static void CheckEqualLength()
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Enter line1 number 1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter line1 number 2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter line1 number 3");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter line1 number 4");
            y2 = Convert.ToInt32(Console.ReadLine());
            float line1length;
            line1length = (float)(Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2))));
            Console.WriteLine("Length of the line1 is: " + line1length);
            int a1, a2, b1, b2;
            Console.WriteLine("Enter line2 number 1");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter line2 number 2");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter line2 number 3");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter line2 number 4");
            b2 = Convert.ToInt32(Console.ReadLine());
            float line2length;
            line2length = (float)(Math.Sqrt((Math.Pow(a2 - a1, 2)) + (Math.Pow(b2 - b1, 2))));
            Console.WriteLine("Length of the line2 is: " + line2length);

            if (line1length == line2length)
            {
                Console.WriteLine("Value of both the lines are equal");
            }
            else
            {
                Console.WriteLine("Value of both the values are not equal");
            }
        }
    }
}

