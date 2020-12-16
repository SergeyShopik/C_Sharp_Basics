using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_5_dataTransfer_MVC.Util
{
    public class UserInput
    {
        public static int Input(string prompt)
        {
            Console.Write(prompt);
            int mark = Convert.ToInt32(Console.ReadLine());
            return mark;
        }
    }
}
