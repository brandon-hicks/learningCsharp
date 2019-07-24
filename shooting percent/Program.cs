using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Xml.Schema;

namespace shooting_percent
{
    class Program
    {
        static void Main(string[] args)
        {
            //shootingpercentage();
            //CalcVol();
            //BooleanPractice();
            //sumation();
            //sum3();
            //homework();
            //cupstoml();
            fibonacciCode();
        }

        static void shootingpercentage()
        {
            Console.WriteLine("Shots taken");
            var takenshots = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Shots made");
            var madeshots = Convert.ToDecimal(Console.ReadLine());
            var shootingPercentage = (madeshots / takenshots) * 100;
            Console.WriteLine(shootingPercentage + "%");
        }

        static void CalcVol()
        {
            Console.WriteLine("Enter length of rectangle");
            var length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width of rectangle");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter height of rectangle");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(length * width * height);
        }

        static void CalcArea()
        {
            Console.WriteLine("Enter the length of a rectangle: ");
            var length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width of a rectangle: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(length * width);
        }

        static void BooleanPractice()
        {
            //bool test = 32.Equals("32");
            // Console.WriteLine(test);

            Console.WriteLine("Pick number from 1 through 100");
            var number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <= 100)
            {
                Console.WriteLine("yep");
            }
            else
            {
                Console.WriteLine("no");
            }

            if (number == 888)
            {
                Console.WriteLine("magic number");
            }
        }

        static void sumation()
        {
            Console.WriteLine("upper bound");
            var lower = Convert.ToInt32(Console.ReadLine());
            for (var i = 100; i > lower; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void sum3()
        {
            var total = 0;
            var step = 3;

            Console.WriteLine("Upper stopping point");
            var upper = Convert.ToInt32(Console.ReadLine());

            //
            for (var i = 0; i <= upper; i += step)
            {
                total = i + total;
            }

            Console.WriteLine(total);
        }

        static void homework()
        {
            var grades = new List<int>();
            var total = 0;

            Console.WriteLine("Number of homework");
            var homework = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < homework; i++)
            {
                Console.WriteLine("Enter grade for homework " + (i + 1));
                grades.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var grade in grades)
            {
                total += grade;
            }

            var average = total / grades.Count;

            Console.WriteLine("Your average is: " + average);
        }

        static void cupstoml()
        {
            // This line was to assign a value to milliliters to aid in the conversion of cups to milliliters;
            double ml = 236.588;

            Console.WriteLine("How many cups");
            var cups = Convert.ToDouble(Console.ReadLine());

            // I used this to multiply cups to milliliters;
            var total = cups * ml;

            Console.WriteLine("Total Milliliters are: " + total);

        }

        static void fibonacciCode()
        {
            var a = 0;
            var b = 1;
            var x = 1;

            Console.WriteLine("Give upper bound: ");
            var upper = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < upper; i++)
            {
                // 'X' is representing the number in which is to be found
                // 'A' is representing "Xn-1"
                // 'B' is representing "Xn-2"
                Console.WriteLine(x);
                x = a + b;
                a = b;
                b = x;
            }
        }
    }
}    