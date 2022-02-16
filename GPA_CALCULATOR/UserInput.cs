using System;
using System.Collections.Generic;
using System.Text;


namespace GPA_CALCULATOR
{
    public class UserInput
    {
        public static void TestMethodsCaller()
        {
            string response;
            do
            {
                Calculations.GetCourseCode();

                Calculations.GetCourseUnit();

                Calculations.GetCourseScore();

                //Table_Draw.GetValues();

                Console.WriteLine("Do you want to input another course?");
                Console.WriteLine("Type YES to continue or NO to view your GPA");
                response = Console.ReadLine();
                Console.Clear();
                if(response == "NO")
                {
                    Table_Draw.DrawTable();
                    Console.WriteLine(Table_Draw.GetValues());
                    Console.WriteLine("\n\n");
                    Calculations.CalculateGPA();
                }
                
            }while(response == "YES");  
            
        }

    }
}
