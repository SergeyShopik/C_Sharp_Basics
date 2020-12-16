using System;

namespace C_sharp_6_static_methods_and_fields_linear_algorithms
{
    class Program
    {
        public static double ConvertInputToDouble()
        {
            string str = Console.ReadLine();
            double num = Convert.ToDouble(str);
            return num;
        }
        //--------------------------------------------------------------------------------
        public static double FindRectanglePerimeter(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Incorrect input: rectangle sides must be positive.\n");
                return 0;
            }

            return (2 * a + 2 * b);
        }
        public static double FindRectangleArea(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Incorrect input: rectangle sides must be positive.\n");
                return 0;
            }

            return Math.Round(a * b, 2);
        }
        public static void PrintRectanglePerimeterAndArea(double a, double b)
        {
            Console.WriteLine("Rectangle perimeter is: " + FindRectanglePerimeter(a, b));
            Console.WriteLine("Rectangle area is: " + FindRectangleArea(a, b));
        }
        //--------------------------------------------------------------------------------
        public const int DIVISOR = 3;
        public static double FindArithmeticalMean(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine("Incorrect input: numbers must be non-negative.");
                return -1;
            }
            return Math.Round(((a + b + c) * 1.0 / DIVISOR), 2);
        }
        public static double FindGeometricMean(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine("Incorrect input: numbers must be non-negative.");
                return -1;
            }
            return Math.Round(Math.Pow((a * b * c * 1.0), 1.0 / DIVISOR), 2);
        }
        public static void PrintArithAndGeomMean(double a, double b, double c)
        {
            Console.WriteLine("Arithmetical mean is: " + FindArithmeticalMean(a, b, c));
            Console.WriteLine("Geometric mean is: " + FindGeometricMean(a, b, c));
        }
        //--------------------------------------------------------------------------------
        public static double FindMin(double a, double b, double c)
        {
            double min = c;
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < c)
            {
                return b;
            }

            return min;
        }
        public static double FindMax(double a, double b, double c)
        {
            double max = c;
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > c)
            {
                return b;
            }

            return max;
        }
        public static void PrintMinAndMax(double a, double b, double c)
        {
            Console.WriteLine("Max number is: " + FindMax(a, b, c));
            Console.WriteLine("Min number is: " + FindMin(a, b, c));
        }
        //--------------------------------------------------------------------------------
        public const double PI = 3.14;
        public static double FindCircleArea(double r)
        {
            if (r <= 0)
            {
                Console.WriteLine("Incorrect input: radius value must be positive.");
                return 0;
            }
            return r * r * PI;
        }
        public static double FindRingArea(double r1, double r2)
        {
            return FindCircleArea(r1) - FindCircleArea(r2);
        }
        //--------------------------------------------------------------------------------
        public static double SolveLinearEquation(double a, double b)
        {
            return Math.Round(-b / a, 2);
        }
        //--------------------------------------------------------------------------------
        public static double FindHypotenuse(double x, double y)
        {
            //trinagula legs squared
            double leg1 = Math.Pow(Math.Abs(y), 2);
            double leg2 = Math.Pow(Math.Abs(x), 2);

            return Math.Pow(leg1 + leg2, 1.0 / 2);
        }
        public static double FindDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2 && y1 == y2)
            {
                Console.WriteLine("Incorrect input: points must not have equal coordinates.");
                return 0;
            }
            //process one-axis equal coordinates
            if (x1 == x2)//distance equals delta(y1,y2)
            {
                return Math.Abs(y1) + Math.Abs(y2);
            }
            if (y1 == y2)//distance equals delta(x1,x2)
            {
                return Math.Abs(x1) + Math.Abs(x2);
            }

            //x1==y2==0 option
            if (x1 == 0 && y2 == 0)
            {
                return FindHypotenuse(x2, y1);
            } else if (x2 == 0 && y1 == 0)
            {
                return FindHypotenuse(x1, y2);
            }

            //--------------------if points aren't on axises------------------------------
            //opposite quadrants
            if ((x1 < 0 ^ x2 < 0) && (y1 < 0 ^ y2 < 0))
            {
                //find distances to the proection of the point - legs of the triangula
                double legX = Math.Abs(x1) + Math.Abs(x2);
                double legY = Math.Abs(y1) + Math.Abs(y2);
                return FindHypotenuse(legX, legY);
            }
            //right or left to the X axis
            else if ((y1 > 0 ^ y2 < 0) && (x1 < 0 ^ x2 < 0))
            {
                double legX = Math.Abs(x1) + Math.Abs(x2);
                double legY;
                if (Math.Abs(y1) > Math.Abs(y2))
                {
                    legY = Math.Abs(y1) - Math.Abs(y2);
                }
                else legY = Math.Abs(y2) - Math.Abs(y1);
                return FindHypotenuse(legX, legY);
            }
            //upper or lower the Y axis
            else if ((x1 > 0 ^ x2 < 0) && (y1 < 0 ^ y2 < 0))
            {
                double legX;
                if (Math.Abs(x1) > Math.Abs(x2))
                {
                    legX = Math.Abs(x1) - Math.Abs(x2);
                }
                else legX = Math.Abs(x2) - Math.Abs(x1);
                double legY = Math.Abs(y1) + Math.Abs(y2);
                return FindHypotenuse(legX, legY);
            }
            //inside one quadrant
            else
            {
                double legX;
                if (Math.Abs(x1) > Math.Abs(x2))
                {
                    legX = Math.Abs(x1) - Math.Abs(x2);
                }
                else legX = Math.Abs(x2) - Math.Abs(x1);

                double legY;
                if (Math.Abs(y1) > Math.Abs(y2))
                {
                    legY = Math.Abs(y1) - Math.Abs(y2);
                }
                else legY = Math.Abs(y2) - Math.Abs(y1);

                return FindHypotenuse(legX, legY);
            }
        }
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("0. Exit\n1. Find rectangle perimeter and area\n" +
                    "2. Find arithmetical and geometric mean\n" +
                    "3. Find min and max between three numbers\n" +
                    "4. Find ring area\n" +
                    "5. Solve linear equation\n" +
                    "6. Find distance between two points\n");
                string str = Console.ReadLine();
                int choice = Convert.ToInt32(str);
                switch(choice)
                {
                    case 0: flag = false; break;
                    case 1:
                        {
                            Console.WriteLine("Enter sides of the rectangle: ");
                            double side1 = ConvertInputToDouble();
                            double side2 = ConvertInputToDouble();

                            if (side1 <= 0 || side2 <= 0)
                            {
                                Console.WriteLine("Incorrect input: rectangle sides must be positive.\n");
                                break;
                            }
                            PrintRectanglePerimeterAndArea(side1, side2);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter three non-negative numbers: ");
                            double num1 = ConvertInputToDouble();
                            double num2 = ConvertInputToDouble();
                            double num3 = ConvertInputToDouble();

                            if (num1 < 0 || num2 < 0 || num3 < 0)
                            {
                                Console.WriteLine("Incorrect input: numbers must be non-negative.");
                                break;
                            }

                            PrintArithAndGeomMean(num1, num2, num3);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter three numbers: ");
                            double a = ConvertInputToDouble();
                            double b = ConvertInputToDouble();
                            double c = ConvertInputToDouble();

                            PrintMinAndMax(a, b, c);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter radius of outer and inner circles");
                            double r1 = ConvertInputToDouble();
                            double r2 = ConvertInputToDouble();

                            if (r1 <= 0 || r2 <= 0)
                            {
                                Console.WriteLine("Incorrect input: radius value must be positive.");
                                break;
                            }

                            double area = FindRingArea(r1, r2);
                            Console.WriteLine("Ring area is: " + area);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter A and B coeficients for an equation (Ax + B = 0): ");
                            double a = ConvertInputToDouble();
                            double b = ConvertInputToDouble();
                            Console.WriteLine(a + "x + " + b + " = 0");
                            double x = SolveLinearEquation(a, b);
                            Console.WriteLine("x = " + x);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Enter coordinates of two points: ");
                            double x1 = ConvertInputToDouble();
                            double y1 = ConvertInputToDouble();
                            double x2 = ConvertInputToDouble();
                            double y2 = ConvertInputToDouble();

                            double result = FindDistanceBetweenTwoPoints(x1, y1, x2, y2);
                            Console.WriteLine("Distance: " + result);
                            break;
                        }
                }
            }
        }
    }
}
