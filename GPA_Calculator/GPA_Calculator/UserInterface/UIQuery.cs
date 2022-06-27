using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPA_Calculator;

namespace GPA_Calculator.UserInterface
{
    public class UIQuery
    {
        public string courseCode;
        public double courseUnit;
        public double courseScore;
        public string askAnswer;

        public void myInput()
        {
            Console.WriteLine("Kindly Input your details in the information space provided below.");
            Console.WriteLine("What is your Course code?: ");
            courseCode = Console.ReadLine();

            Console.WriteLine("Input your Course Unit here: ");
            courseUnit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input your score: ");
            courseScore = Convert.ToDouble(Console.ReadLine());
        }

        public void askAgain()
        {
            Console.WriteLine("Would you like to include another data(Yes/No)?");
            askAnswer = Console.ReadLine();

            if ( askAnswer == "yes" || askAnswer == "YES" || askAnswer == "Yes" )
            {
                UIQuery uiquery = new UIQuery();
                uiquery.myInput();
            }
            else
            {
                Console.WriteLine("Done");
            }
        }
    }
}
