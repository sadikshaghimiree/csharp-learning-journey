using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class Claculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== CALCULATOR =====");
            Console.Write("1. Add\r\n2. Subtract\r\n3. Multiply\r\n4. Divide\r\nChoose option (1-4):");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Enter two numbers to Calculate: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        double sum = Add(num1,num2);
                        Console.WriteLine($"The ans is : {sum}");
                        break;
                    }

                case 2:
                    {
                        double diff = Sub(num1, num2);
                        Console.WriteLine($"The ans is : {diff}");
                        break;
                    }

                case 3:
                    {
                        double mul = Multiply( num1,  num2);
                        Console.WriteLine($"The ans is : {mul}");
                        break;
                    }

                case 4:
                    {
                        double div = division( num1, num2);
                        Console.WriteLine($"The ans is : {div}");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Invalid number, choose from 1-4");
                        break;
                    }


            }

            static double Add(double num1, double num2)
            {
                return num1 + num2;
            }

            static double Sub(double num1, double num2)
            {
                return num1 - num2;
            }

            static double Multiply(double num1, double num2)
            {
                return num1 * num2;
            }

            static double division(double num1, double num2)
            {
                if(num2==0)
                {
                    Console.WriteLine("Undefine");
                    return 0;
                }
                else 
                return num1 / num2;
            }










        }
        

    }
}
