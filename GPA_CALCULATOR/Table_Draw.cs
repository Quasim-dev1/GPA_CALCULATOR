using System;
using System.Collections.Generic;
using System.Text;

namespace GPA_CALCULATOR
{
    class Table_Draw
    {
        //public static string ResultDisplay = ""; 
        public static void DrawTable()
        {


            Console.WriteLine("|---------------|---------------|----------------|---------------|---------------|---------------|");
            Console.WriteLine("|  COURSE CODE  |  COURSE UNIT  |    GRADE       | GRADE UNIT    | WEIGHT POINT  |   REMARK      |");
            Console.WriteLine("|---------------|---------------|----------------|---------------|---------------|---------------|");
        }

        public static string GetValues()
        {
            string course = Calculations.NameAndCode;
            double crUnit = Calculations.CourseUnit;
            string grade = Calculations.grade;
            double grdUnit = Calculations.gradeUnit;
            double wtPoint = Calculations.weightPoint;
            string remark = Calculations.remark;

            string ResultDispaly = $"|\t{course}  |\t  {crUnit}     |\t{grade}\t |\t{grdUnit}  \t |\t{wtPoint}\t | {remark} \t |";

            return ResultDispaly;
        }
           
                      
        
        
    }
}
