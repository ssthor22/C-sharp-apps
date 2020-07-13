//Class:		ERAU ISTA220 Programming Fundamentals
//Student:		Seth Thor
//Instructor: 	Christine E Lee, Instructor
//Date: 		7/3/2020

/************************************************************************

This code calculates various mathematical formulas

Revisions: 

Revision Date:

Revised by: 

************************************************************************/

using System;

namespace HW_EX1A___Seth
{
    class Program
    {
        // Calculates the circumference and area of a circle
        public static void Circle(string strradius)
        {
            int intradius = int.Parse(strradius);

            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");

            double area = Math.PI * Math.Pow(intradius, 2);
            Console.WriteLine($"The area is {area}");

        }

        // Calculates the volume of a hemisphere
        public static void Hemisphere(string strradius)
        {
            int intradius = int.Parse(strradius);
            double volume = 0.5 * (4.0 / 3.0) * Math.PI * Math.Pow(intradius, 3);
            Console.WriteLine($"The volume is {volume}");
        }

        // Calculates area of a triangle using Heron's formula
        public static void Triangle(string stra, string strb, string strc)
        {
            int inta = int.Parse(stra);
            int intb = int.Parse(strb);
            int intc = int.Parse(strc);

            double p = (inta + intb + intc) * 0.5;
            double area = Math.Sqrt(p * (p - inta) * (p - intb) * (p - intc));
            Console.WriteLine($"The area is {area}");

        }

        // Computes the quadratic formula to give 2 real solutions
        public static int Quadratic(string stra, string strb, string strc)
        {
            int done = 0;
            double inta = double.Parse(stra);
            double intb = double.Parse(strb);
            double intc = double.Parse(strc);

            double discriminant = Math.Pow(intb, 2) - 4 * inta * intc;
            if( discriminant < 0)
            {
                Console.WriteLine("Imaginary solution detected...pick your coefficients again!");
                done = 0;
            }
            else
            {
                double possoln = (-intb + Math.Sqrt(discriminant)) * (0.5 / inta);
                double negsoln = (-intb - Math.Sqrt(discriminant)) * (0.5 / inta);
                Console.WriteLine($"The positive solution is {possoln}");
                Console.WriteLine($"The negative solution is {negsoln}");
                done = 1;
            }

            return done;

        }

        static void Main(string[] args)
        {
            //Part 1: Circle area and circumference
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            Circle(strradius);

            //Part 2: Hemisphere volume
            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.Write("Enter an integer for the radius: ");
            strradius = Console.ReadLine();
            Hemisphere(strradius);

            //Part 3: Triangle area - Heron's formula
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            Console.Write("Enter integer length for side a: ");
            string stra = Console.ReadLine();
            Console.Write("Enter integer length for side b: ");
            string strb = Console.ReadLine();
            Console.Write("Enter integer length for side c: ");
            string strc = Console.ReadLine();
            Triangle(stra, strb, strc);

            // Part 4: Quadratic formula
            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            int done = 0;
            while (done != 1)
            {
                Console.Write("Enter integer for coefficient, a: ");
                stra = Console.ReadLine();
                Console.Write("Enter integer for coefficient, b: ");
                strb = Console.ReadLine();
                Console.Write("Enter integer for coefficient, c: ");
                strc = Console.ReadLine();
                done = Quadratic(stra, strb, strc);
            }

        }
    }
}
