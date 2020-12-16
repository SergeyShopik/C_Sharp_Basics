using System;
using C_sharp_5_dataTransfer_MVC.View;
using C_sharp_5_dataTransfer_MVC.Util;
using C_sharp_5_dataTransfer_MVC.Model;

namespace C_sharp_5_dataTransfer_MVC
{
    class Student
    {
        public int mark = 4;
    }
    class Program
    {
        public static void Test(ref int a)
        {
            a += 10;
        }
        public static void Init(out int a)//value by ref(out)
        {
            a = 10;
        }
        public static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        public static void TestStudent(Student st)
        {
            st.mark += 1;
        }
        static void Main(string[] args)
        { 
            int mark1 = UserInput.Input("Input first mark: ");
            int mark2 = UserInput.Input("Input second mark: ");
            int mark3 = UserInput.Input("Input third mark: ");

            double avg = BusinessLogic.CalculateAvgMark(mark1, mark2, mark3);
            string result = string.Format("Avg mark = {0:f}\n", avg);
            Printer.Print(result);

            //--------------------------------------------------------------------------------
            //int number = 10, numout;

            //Console.WriteLine("Before: number = " + number);
            //Test(ref number);
            //Console.WriteLine("After: number = " + number);

            //Init(out numout);

            //int a = 10, b = 20;
            //Swap(ref a, ref b);
            //Console.WriteLine(a + " " + b);

            //Student student = new Student();
            //TestStudent(student);
            //Console.WriteLine(student.mark);
        }
    }
}
