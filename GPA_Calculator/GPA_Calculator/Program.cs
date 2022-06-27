using System;
using System.Collections.Generic;
using GPA_Calculator.UserInterface;

namespace GPA_Calculator
{
    public class GPA_Calculator
    {
        public static void Main(string[] args)
        {
            UIQuery query = new UIQuery();
            query.myInput();

            UIQuery repeat = new UIQuery();
            repeat.askAgain();

            Console.WriteLine();
        }
    }
}