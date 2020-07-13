//Class:		ERAU ISTA220 Programming Fundamentals
//Student:		Seth Thor
//Instructor: 	Christine E Lee, Instructor
//Date: 		07/08/2020

/************************************************************************

This code is for HW EX 2A where we will be calculating averages

Revisions: 

Revision Date:

Revised by: 

************************************************************************/

using System;

namespace EX_2A_HW
{
    class Program
    {
        // This function performs the average calculation and grade assignment
        static void AvgScore(int sum, int n)
        {
            double avg; double ndbl = Convert.ToDouble(n);
            avg = sum / ndbl;

            if (avg >= 90.0)
            {
                Console.WriteLine($"You have entered {n} scores | The average score is: {avg} | A");
            }
            else if (80 <= avg & avg < 90)
            {
                Console.WriteLine($"You have entered {n} scores | The average score is: {avg} | B");
            }
            else if (70 <= avg & avg < 80)
            {
                Console.WriteLine($"You have entered {n} scores | The average score is: {avg} | C");
            }
            else if (60 <= avg & avg < 70)
            {
                Console.WriteLine($"You have entered {n} scores | The average score is: {avg} | D");
            }
            else if (avg < 60)
            {
                Console.WriteLine($"You have entered {n} scores | The average score is: {avg} | F");
            }

        }

        // Sum of numbers
        static void SumOfNums()
        {
            Console.WriteLine("\n-------------- Sum of Numbers -------------");
            int num; int sum = 0;

            for (int i=0; i < 10; i++ )
            {
                Console.Write($"You have entered {i} numbers | Enter your next number: ");
                num = int.Parse( Console.ReadLine() );
                while (num < 0 | num > 100)
                {
                    Console.Write("\tNumber must be between 0 and 100! Try again: ");
                    num = int.Parse(Console.ReadLine());
                }

                sum = sum + num;

            }

            Console.WriteLine($"You have entered 10 numbers | The sum of your numbers is: {sum}");
            
        }

        // Average 10 scores
        static void AvgTenScores()
        {
            Console.WriteLine("\n-------------- Avg 10 Scores -------------");
            int num; int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"You have entered {i} scores | Enter your next score: ");
                num = int.Parse(Console.ReadLine());

                // Check if numbers fall between 0 - 100. If not, prompt to enter number again.
                while (num < 0 | num > 100)
                {
                    Console.Write("\tScore must be between 0 and 100! Try again: ");
                    num = int.Parse(Console.ReadLine());
                }

                sum = sum + num;
            }

            AvgScore(sum, 10);

        }

        /* 
         * Average of specific number of scores
           User will enter how many scores they plan to input, then the average will be taken
        */
        static void Avg_inputN_Scores()
        {
            Console.WriteLine("\n-------- Avg specific number of scores --------");
            int num; int sum = 0;

            Console.Write("How many test scores will you enter? ");
            int inputN = int.Parse( Console.ReadLine() );

            for (int i = 0; i < inputN; i++)
            {
                Console.Write($"You have entered {i} scores | Enter your next score: ");
                num = int.Parse(Console.ReadLine());

                // Check if numbers fall between 0 - 100. If not, prompt to enter number again.
                while (num < 0 | num > 100)
                {
                    Console.Write("\tScore must be between 0 and 100! Try again: ");
                    num = int.Parse(Console.ReadLine());
                }

                sum = sum + num;
            }

            AvgScore(sum, inputN);

        }

        //Enter an arbitrary number of scores and get the avg grade
        static void Avg_N_Scores()
        {
            Console.WriteLine("\n-------- Avg non-specific number of scores --------");
            int num; double avg; int sum = 0;
            bool done = false; int i = 0;

            while (done == false)
            {
                Console.Write($"{i} scores entered | Enter your next score ('d' for done): ");

                /* If user enters anything other than an int, try-catch will
                 * stop the summing process and move on to average calculation. */
                try
                {
                    num = int.Parse(Console.ReadLine());
                    while (num < 0 | num > 100)
                    {
                        Console.Write("\tScore must be between 0 and 100! Try again: ");
                        num = int.Parse(Console.ReadLine());
                    }

                    sum = sum + num;
                    i++;
                }
                catch
                {
                    // In the case that no scores were entered. Important to include so avg/0 doesn't occur.
                    if (i==0)
                    {
                        Console.WriteLine($"You have entered 0 scores | The average score is: 0 | F");
                    }
                    else
                    {
                        AvgScore(sum, i);
                        done = true;
                    }
                }
                

            }

        }

        // Main menu
        static void Main(string[] args)
        {
            int userinput;
            bool done = false;
            while (done == false)
            {
                Console.WriteLine(
                    "\n====================\n" +
                    "Calculating Averages" +
                    "\n====================");
                Console.WriteLine("(1) Sum of Numbers");
                Console.WriteLine("(2) Average ten scores");
                Console.WriteLine("(3) Average a specific number of scores");
                Console.WriteLine("(4) Average a non-specific number of scores");
                Console.WriteLine("(5) Exit");
                Console.Write("Choose an option: ");

                userinput = int.Parse( Console.ReadLine() );
                if (userinput == 1)
                {
                    SumOfNums();
                }
                else if (userinput == 2)
                {
                    AvgTenScores();
                }
                else if (userinput == 3)
                {
                    Avg_inputN_Scores();
                }
                else if (userinput == 4)
                {
                    Avg_N_Scores();
                }
                else
                {
                    Console.WriteLine("\n=============\nAll done!\n=============");
                    done = true;
                }
            }
            
            
            
            
        }
    }
}
