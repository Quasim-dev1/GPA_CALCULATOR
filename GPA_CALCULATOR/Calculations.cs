using System;
using System.Collections.Generic;
using System.Text;

namespace GPA_CALCULATOR
{
    public class Calculations
    {
        public static string[] gradeArray;
        public static double GPA;
        public static string grade = "";
        public static double gradeUnit = 0;
        public static double weightPoint = 0;
        public static string remark = "";
        public static string[] remarkArray;
        public static double totalWeightPoint = 0;
        public static double totalGradeUnit = 0;

        public static string NameAndCode { get; set; }
        public static double CourseUnit { get; set; }
        public static double CourseScore { get; set; }

        public static string GetCourseCode()
        {
            Console.Write("Input the course code: ");
            string courseCode = Console.ReadLine();
            while (courseCode.Length != 6)
            {
                Console.Write("Invalid course code\nplease enter a valid course code: ");
                courseCode = Console.ReadLine();
            }
            NameAndCode = courseCode;
            return NameAndCode;
        }

        public static double GetCourseUnit()
        {
            Console.Write("Input the course unit: ");
            string courseUnitString = Console.ReadLine();
            double courseUnit = double.Parse(courseUnitString);
            CourseUnit = courseUnit;
            return CourseUnit;
        }

        public static double GetCourseScore()
        {
            gradeArray = new string[] { "A", "B", "C", "D", "E", "F" };
            Console.Write("Input the course score: ");
            string courseScoreString = Console.ReadLine();
            double courseScore = double.Parse(courseScoreString);
            remarkArray = new string[] {"Excellent","Very Good","Good","Fair","Pass","Fail"};
            if (courseScore >= 70 && courseScore <= 100)
            {
                grade = gradeArray[0];
                gradeUnit = 5;
                weightPoint = CourseUnit * gradeUnit;
                remark = remarkArray[0];
                Console.WriteLine($"CourseCode: {NameAndCode}\t\t Course Unit: {CourseUnit}\t\t Grade: {grade}\t\t" +
                                  $"gradeUnit: {gradeUnit}\t\tweightPoint: {weightPoint}\t\tRemark: {remark}");
            }

            else if (courseScore >= 60 && courseScore <= 69)
            {
                grade = gradeArray[1];
                gradeUnit = 4;
                weightPoint = CourseUnit * gradeUnit;
                remark = remarkArray[1];
                Console.WriteLine($"Grade: {grade}\ngradeUnit: {gradeUnit}\nweightPoint: {weightPoint}");
                Console.WriteLine($"Remark: Very Good");
            }

            else if (courseScore >= 50 && courseScore <= 59)
            {
                grade = gradeArray[2];
                gradeUnit = 3;
                weightPoint = CourseUnit * gradeUnit;
                remark = remarkArray[2];
                Console.WriteLine($"Grade: {grade}\ngradeUnit: {gradeUnit}\nweightPoint: {weightPoint}");
                Console.WriteLine($"Remark: Good");
            }

            else if (courseScore >= 45 && courseScore <= 49)
            {
                grade = gradeArray[3];
                gradeUnit = 2;
                weightPoint = CourseUnit * gradeUnit;
                remark = remarkArray[3];
                Console.WriteLine($"Grade: {grade}\ngradeUnit: {gradeUnit}\nweightPoint: {weightPoint}");
                Console.WriteLine($"Remark: Fair");
            }

            else if (courseScore >= 40 && courseScore <= 44)
            {
                grade = gradeArray[4];
                gradeUnit = 1;
                weightPoint = CourseUnit * gradeUnit;
                remark = remarkArray[4];
                Console.WriteLine($"Grade: {grade}\ngradeUnit: {gradeUnit}\nweightPoint: {weightPoint}");
                Console.WriteLine($"Remark: Pass");
            }

            else if (courseScore >= 0 && courseScore <= 39)
            {
                grade = gradeArray[5];
                gradeUnit = 0;
                weightPoint = CourseUnit * gradeUnit;
                remark = remarkArray[5];
                Console.WriteLine($"Grade: {grade}\ngradeUnit: {gradeUnit}\nweightPoint: {weightPoint}");
                Console.WriteLine($"Remark: Fail");
            }

            else
            {
                Console.WriteLine("Invalid score entered!\nPlease enter a score between 0 and 100");
            }

            totalWeightPoint += weightPoint;
            totalGradeUnit += gradeUnit;
            GPA = totalWeightPoint / totalGradeUnit;
            
            CourseScore = courseScore;
            return CourseScore;
        }

        public static double CalculateGPA()
        {
            
            Console.WriteLine($"Total Grade Unit is  {totalGradeUnit}");
            Console.WriteLine($"Total Weight Point is  {totalWeightPoint}");
            Console.WriteLine($"Your GPA is {Math.Round(GPA, 2)} to 2 decimal places.");
            return GPA;
        } 
    }

}
