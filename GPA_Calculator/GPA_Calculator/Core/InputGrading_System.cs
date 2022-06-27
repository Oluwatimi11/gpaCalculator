using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPA_Calculator.UserInterface;

namespace GPA_Calculator.Core
{
   
    public class InputGrading_System : UIQuery
    {
        public char grade;
        /*public char gradeA = 'A';
        public char gradeB = 'B';
        public char gradeC = 'C';
        public char gradeD = 'D';
        public char gradeE = 'E';
        public char gradeF = 'F';*/
        public string remark;
        public int gradeUnit;

        public void gradingSystem()
        {
            if (courseScore >= 70 && courseScore <= 100)
            {
               grade = 'A';
               remark = "Excellent";
            }

            else if (courseScore >= 60 && courseScore <= 69)
            {
                grade = 'B';
                remark = "Very Good";
            }
            else if (courseScore >= 50 && courseScore <= 59)
            {
                grade = 'C';
                remark = "Good";
                
            }
            else if (courseScore >= 45 && courseScore <= 49)
            {
                grade = 'D';
                remark = "Fair";
            }
            else if (courseScore >= 40 && courseScore <= 44)
            {
                grade = 'E';
                remark = "Pass";
            }
            else if (courseScore >= 0 && courseScore <= 39)
            {
                grade = 'F';
                remark = "Fail";
            }
            else
            {
                Console.WriteLine("Sorry, Invalid Input");
            }

        }
    }
}
