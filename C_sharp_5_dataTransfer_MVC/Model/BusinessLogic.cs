using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_5_dataTransfer_MVC.Model
{
    public class BusinessLogic
    {
        public const int STUDENTS_NUMBER = 3;
        public static double CalculateAvgMark(int a, int b, int c)
        {
            return (a + b + c) * 1.0 / STUDENTS_NUMBER;
        }
    }
}
