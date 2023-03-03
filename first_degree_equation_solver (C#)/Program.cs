using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static float get_input_from_user(string var)
        {
            Console.WriteLine("please enter the value of {0}",var);
            float number = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
            return number;
        }
        static void solve_equation(float var_a,float var_b)
        {
            if (var_a==0)
            {
                if(var_b==0)
                {
                    Console.WriteLine("all numbers are solutions to this equation");
                }
                else
                {
                    Console.WriteLine("this Equation has no solutions");
                }
            }
            else
            {
                float Result=-var_b/var_a;
                Console.WriteLine("Result = {0}",Result);
            }
        }
        static void Main(string[] args)
        {
            float var_a=get_input_from_user("a");
            float var_b=get_input_from_user("b");
            solve_equation(var_a,var_b);
            Console.ReadKey();
        }
    }
}
