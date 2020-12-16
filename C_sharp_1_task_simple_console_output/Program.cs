using System;
class Program
{
    public const int MONTHS_PER_YEAR = 12; //static по дефолту если есть const
    public const int MINS_PER_HOUR = 60;
    public const int MIN_INT = -2147483648;
    public const int MAX_INT = 2147483647;

    public static int Sum(int a, int b)
    {
        return a + b;
    }
    public static int countMonths(int a)
    {
        return a * MONTHS_PER_YEAR;
    }
    public static int countDays(int a)
    {
        return countMonths(a) * 365;
    }
    public static int countHours(int a)
    {
        return countDays(a) * 24;
    }
    public static int countMins(int a)
    {
        return countHours(a) * 60;
    }
    public static string printAge(int a)
    {
        string result = "Months: " + countMonths(a) + "\nDays: " + countDays(a)
            + "\nHours: " + countHours(a) + "\nMinutes: " + countMins(a);
        return result;
    }

    public static void maxNum()
    {
        //int max = MIN_INT;
        //int num_of_numbers = 4;
        Console.WriteLine("Enter four numbers: ");
        
        string temp1 = Console.ReadLine();
        string temp2 = Console.ReadLine();
        string temp3 = Console.ReadLine();
        string temp4 = Console.ReadLine();

        int num1 = Convert.ToInt32(temp1);
        int num2 = Convert.ToInt32(temp2);
        int num3 = Convert.ToInt32(temp3);
        int num4 = Convert.ToInt32(temp4);

        int max1 = 0, max2 = 0, maxRes = 0;
        if (num1 > num2)
        {
            max1 = num1;
        }
        else max1 = num2;

        if (num3 > num4)
        {
            max2 = num3;
        }
        else max2 = num4;

        if (max1 > max2)
        {
            maxRes = max1;
        }
        else maxRes = max2;

      
        Console.WriteLine("Max num is: ");
        Console.WriteLine(maxRes);
    }
    static void Main(string[] args)
    {
        //Console.Write("Input a: ");//write не переводит курсор на новую строку в отличие от writeLine
        //string a = Console.ReadLine();

        //Console.Write("Input b: ");
        //string b = Console.ReadLine();

        //int numberA = Convert.ToInt32(a);
        //int numberB = Convert.ToInt32(b);

        ////int iA = System.Int32.Parse(a); older method

        //string result = a + " + " + b + " = " + Sum(numberA, numberB);

        //Console.WriteLine(result);
        //Console.ReadLine();

        //Console.Write("Enter your age: ");
        //string age = Console.ReadLine();

        //int iAge = Convert.ToInt32(age);

        //Console.Write(printAge(iAge));

        maxNum();

    }
}