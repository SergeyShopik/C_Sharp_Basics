using System;

namespace C_sharp_4_basic_IO
{
    class Program
    {
        //reverse given number (ex. 1234 -> 4321)
        public static int ReverseNum(int num)
        {
            if (num < 10)
            {
                Console.WriteLine("Input number must be positive and contain at least 2 digits");
                return 0;
            }

            int reverse_num = 0, digits_count = 1;
            for (int i = num; i > 9; i /= 10, digits_count++); //count digits
            for (int i = digits_count - 1; i >= 0; i--) //reverse the number
            {
                int temp = num % 10;
                reverse_num += temp * (int)Math.Pow(10, i);
                num /= 10;
            }

            return reverse_num;
        }

        //find amount of digits in the number
        public static int FindNumOfDigits(int num)
        {
            int num_of_digits = 1;
            for (int i = num; i > 9; i /= 10, num_of_digits++) ;
            return num_of_digits;
        }
        //find arithmetical mean
        public static double CalculateArithMean(int num)
        {
            int sum = 0;
            int num_of_digits = FindNumOfDigits(num);
            for (int j = num; j > 0; j /= 10)
            {
                sum += j % 10;
            }
            return Math.Round(((double)sum / num_of_digits), 2);
        }
        //find geometric mean
        public static double CalculateGeomMean(int num)
        {
            double mult = 1;
            int num_of_digits = FindNumOfDigits(num);
            //multiply all digits
            for (int j = num; j > 0; j /= 10)
            {
                mult *= j % 10;
            }
            //find mean
            double gm = Math.Pow(mult, (double)1 / num_of_digits);

            return gm;
        }
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("0. Exit\n1. Reverse number\n2. Show seconds elapsed after midnight" +
                    "\n3. Find arithmetical and geometric mean");
                string str = Console.ReadLine();
                int choice = Convert.ToInt32(str);

                switch(choice)
                {
                    case 0: flag = false; break;
                    case 1:
                        {
                            Console.WriteLine("Enter number to reverse: ");
                            string temp = Console.ReadLine();
                            int num = Convert.ToInt32(temp);
                            Console.WriteLine(ReverseNum(num));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(DateTime.Now.TimeOfDay);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the number: ");
                            string temp = Console.ReadLine();
                            int num = Convert.ToInt32(temp);
                            Console.WriteLine("Arithmetical mean is: " + CalculateArithMean(num) +
                                "\nand geometric mean is: " + CalculateGeomMean(num));
                            break;
                        }
                }
            }
        }
    }
}
