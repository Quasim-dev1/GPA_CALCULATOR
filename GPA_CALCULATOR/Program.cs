using System;
using System.Collections.Generic;
namespace GPA_CALCULATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            // UserInput.TestMethodsCaller();
            string str = "Life";
            Console.WriteLine(String.ToReverse();

        }



        /*Duplicate characters: Find the top most repeated character 
            in a string. For instance, given a string ‘hello world’, 
           the top most repeated character is ‘l’ because it can be found 3 times in the string.*/

        /*public static char GetMostRepeatedCharacter(string sentence)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for(int i = 0; i < sentence.Length; i++ )
            {
                if(sentence.ContainsKey(s))
            }*/

        /*int characterCount = 0;
        if(sentence.Length == 0)
        {
            return;
        }
*/

        //dictionary.sentence

        /*You have a list of integers, and for each index you want to find the product of every integer except 
        the integer at that index.For example a list[1, 3, 7, 4] returns[84, 28, 12, 21] which is by 
        calculating[7 * 3 * 4, 1 * 7 * 4, 1 * 3 * 4, 1 * 7 * 3].*/

        public static List<int> ProductOfOtherIntegers(List<int> numbers)
        {
            foreach
        }

















            /* Poker Chips:
                 Luigy works in a Casino and he gives customers 
                 poker chips in exchange of money.Find the minimum number 
                 of chips Luigy can use to match the customer requests.He has
                     chips worth 100, 50, 25, 10, 5, 1. For example, for 126 Luigy
                     should give 3 chips (100, 25, 1).*/
        /*public static List<int> ExchangeChipsForMoney(int amount)
        {
            if(amount < 0)
            {
                return new List<int>();
            }

            List<int> li = new List<int>();
            int noOf100s = (int) amount / 100;
            amount = amount - noOf100s * 100;
            int noOf50s = (int)amount / 50;
            amount = amount - noOf50s * 50;
            int noOf20s = (int)amount / 20;

        }*/




















































































        //UserInput.GetCourseUnit();

        /*test.GetNAmeAndCode = Console.ReadLine();
        Console.WriteLine(test.GetNAmeAndCode);*/
        //Console.WriteLine(Math.Round(0.23678, 3));

        /*string grade = "";
            double gradeUnit = 0;
            double weightPoint = 0;
            double courseUnit = 0;
            double totalCourseUnitRegistered = 0;
            //double totalCourseUnitPassed = 0;
            //double totalCoursesFailed = 0;
            double totalGradeUnit = 0;
            double totalWeightPoint = 0;

            while (true)
            {

                Console.Write("Input the course name and code: ");
                string courseNameAndCode = Console.ReadLine();

                if (courseNameAndCode == "exit")
                {
                    break;
                }

                while (courseNameAndCode.Length != 6)
                {
                    Console.Write("Invalid course code\nplease enter a valid course code: ");
                    courseNameAndCode = Console.ReadLine();
                }

                Console.Write("Input the course unit: ");
                string courseUnitStr = Console.ReadLine();
                if (courseUnitStr == "exit")
                {
                    break;
                }

                courseUnit = double.Parse(courseUnitStr);
                while (courseUnit < 1 || courseUnit > 5)
                {
                    Console.Write("Invalid course unit, Course unit shoud be between 1 and 5\n" +
                                      "Input a valid course unit: ");
                    courseUnitStr = Console.ReadLine();
                    courseUnit = double.Parse(courseUnitStr);
                }
                totalCourseUnitRegistered += courseUnit;


                Console.Write("Input the course score: ");
                string courseScoreStr = Console.ReadLine();
                if (courseScoreStr == "exit")
                {
                    break;
                }

                double courseScore = double.Parse(courseScoreStr);


                if (courseScore >= 70 && courseScore <= 100)
                {
                    grade = "A";
                    gradeUnit = 5;
                    weightPoint = courseUnit * gradeUnit;
                    Console.WriteLine($"Grade: {grade}\ngradeUnit: {gradeUnit}\nweightPoint: {weightPoint}");
                    Console.WriteLine($"Remark: Excellent");
                }

                else if (courseScore >= 60 && courseScore <= 69)
                {
                    grade = "B";
                    gradeUnit = 4;
                    weightPoint = courseUnit * gradeUnit;
                    Console.WriteLine($"Grade: {grade}\ngradeUnit: {gradeUnit}\nweightPoint: {weightPoint}");
                    Console.WriteLine($"Remark: Very Good");
                }

                else if (courseScore >= 50 && courseScore <= 59)
                {
                    grade = "C";
                    gradeUnit = 3;
                    weightPoint = courseUnit * gradeUnit;
                    Console.WriteLine($"Grade: {grade}\ngradeUnit: {gradeUnit}\nweightPoint: {weightPoint}");
                    Console.WriteLine($"Remark: Good");
                }

                else if (courseScore >= 45 && courseScore <= 49)
                {
                    grade = "D";
                    gradeUnit = 2;
                    weightPoint = courseUnit * gradeUnit;
                    Console.WriteLine($"Grade: {grade}\ngradeUnit: {gradeUnit}\nweightPoint: {weightPoint}");
                    Console.WriteLine($"Remark: Fair");
                }

                else if (courseScore >= 40 && courseScore <= 44)
                {
                    grade = "E";
                    gradeUnit = 1;
                    weightPoint = courseUnit * gradeUnit;
                    Console.WriteLine($"Grade: {grade}\ngradeUnit: {gradeUnit}\nweightPoint: {weightPoint}");
                    Console.WriteLine($"Remark: Pass");
                }

                else if (courseScore >= 0 && courseScore <= 39)
                {
                    grade = "F";
                    gradeUnit = 0;
                    weightPoint = courseUnit * gradeUnit;
                    //totalCoursesFailed += weightPoint;
                    Console.WriteLine($"Grade: {grade}\ngradeUnit: {gradeUnit}\nweightPoint: {weightPoint}");
                    Console.WriteLine($"Remark: Fail");
                }

                else
                {
                    Console.WriteLine("Invalid score entered!\nPlease enter a score between 0 and 100");
                }
                totalWeightPoint += weightPoint;
                totalGradeUnit += gradeUnit;
            }

            double GPA = totalWeightPoint / totalGradeUnit;


            //totalCourseUnitPassed = totalCourseUnitRegistered - totalCoursesFailed;
            //Console.WriteLine($"Total course unit passed is: {totalCourseUnitPassed}"); 
            Console.WriteLine($"Total Course Unit Registered is  {totalCourseUnitRegistered}");
            Console.WriteLine($"Total Grade Unit is  {totalGradeUnit}");
            Console.WriteLine($"Total Weight Point is  {totalWeightPoint}");
            Console.WriteLine($"Your GPA is {Math.Round(GPA, 2)} to 2 decimal places.");

        //}*/
        }
}
