using System;

namespace LetterGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get user input for grade percentage
            Console.Write("Enter your grade percentage: ");
            int gradePercentage = int.Parse(Console.ReadLine());

            // Determine the letter grade
            string letterGrade;
            if (gradePercentage >= 90)
            {
                letterGrade = "A";
            }
            else if (gradePercentage >= 80)
            {
                letterGrade = "B";
            }
            else if (gradePercentage >= 70)
            {
                letterGrade = "C";
            }
            else if (gradePercentage >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            // Determine if the user passed the course
            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Keep trying! You'll do better next time.");
            }

            // Determine the grade sign
            string sign = "";
            if (letterGrade != "A" && letterGrade != "F")
            {
                int lastDigit = gradePercentage % 10;
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }
            else if (letterGrade == "A" && gradePercentage < 93)
            {
                sign = "-";
            }

            // Print the letter grade and sign
            Console.WriteLine($"Your letter grade is {letterGrade}{sign}.");
        }
    }
}
