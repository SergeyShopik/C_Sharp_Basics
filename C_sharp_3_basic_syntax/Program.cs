using System;

namespace C_sharp_3_basic_syntax
{
    class Program
    {
        //celsius to fahrenheit convertion
        public static double C_to_F(double c)
        {
            double result;
            result = c * 9.0 / 5.0 + 32;
            return result;
        }

        //fahrenheit to celsius convertion
        public static double F_to_C(double f)
        {
            double result;
            result = (f - 32) * 5.0 / 9.0;
            return result;
        }

        //find price of 1kg of chocolate
        public static double CalculateChocoPricePerKG(double choco_weight, double choco_price)
        {
            if (choco_weight <= 0 || choco_price <= 0)
            {
                Console.WriteLine("Invalid parameter(s) for \"CalculateChocoPricePerKG\"");
                return 0;
            }

            return choco_price * (1 / choco_weight);
        }
        //find price of 1kg of gelatin candies
        public static double CalculateGelatinPricePerKG(double gelatin_weight, double gelatin_price)
        {
            if (gelatin_weight <= 0 || gelatin_price <= 0)
            {
                Console.WriteLine("Invalid parameter(s) for \"CalculateGelatinPricePerKG\"");
                return 0;
            }

            return gelatin_price * (1 / gelatin_weight);
        }
        //print chocolate and gelatin prices and price difference
        public static void PrintSweetsPrices()
        {
            Console.WriteLine("Please enter choco_weight, choco_price and gelatin_weight, gelatin_price:");
            string temp1 = Console.ReadLine();
            string temp2 = Console.ReadLine();
            string temp3 = Console.ReadLine();
            string temp4 = Console.ReadLine();

            double choco_weight = Convert.ToDouble(temp1);
            double choco_price = Convert.ToDouble(temp2);
            double gelatin_weight = Convert.ToDouble(temp3);
            double gelatin_price = Convert.ToDouble(temp4);

            double choco = CalculateChocoPricePerKG(choco_weight, choco_price);
            double gelatin = CalculateGelatinPricePerKG(gelatin_weight, gelatin_price);

            Console.WriteLine("Chocolate price is: " + Math.Round(choco, 2));
            Console.WriteLine("\nGelatin price is: " + Math.Round(gelatin, 2));
            double diff = choco / gelatin;
            if (diff > 1)
            {
                Console.WriteLine("\nChocolate price is " + Math.Round(diff, 2) + " times higher than gelatin.");
            } else if (diff < 1)
            {
                Console.WriteLine("\nGelatin price is " + Math.Round(2 - diff, 2) + " times higher than chocolate.");
            }
            else
            {
                Console.WriteLine("\nPrices are equal.");
            }
        }

        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("0. exit\n1. celsius to fahrenheit\n2. fahrenheit to celsius" +
                    "\n3. sweets prices");
                string menu = Console.ReadLine();
                int choice = Convert.ToInt32(menu);

                switch (choice)
                {
                    case 0: flag = false; break;
                    case 1:
                        {
                            Console.WriteLine("Enter temperature in C: ");
                            string cTemp = Console.ReadLine();
                            double c = Convert.ToDouble(cTemp);
                            double f = C_to_F(c);
                            Console.WriteLine(f);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter temperature in F: ");
                            string fTemp = Console.ReadLine();
                            double f = Convert.ToDouble(fTemp);
                            double c = C_to_F(f);
                            Console.WriteLine(c);
                            break;
                        }
                    case 3:
                        {
                            PrintSweetsPrices();
                            break;
                        }
                }
            }
        }
    }
}
