using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Arithmatic
    {
        double a, b;
        String operator_;

        public void GetData()
        {
            Console.WriteLine("Enter a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operator");
            operator_ = Console.ReadLine();
        }

        public void cal()
        {
            switch (operator_)
            {
                case "+":
                    Console.WriteLine($"{a} + {b} = {a+b}");
                    break;
                case "-":
                    Console.WriteLine($"{a} + {b} = {a-b}");
                    break;
                case "*":
                    Console.WriteLine($"{a} + {b} = {a*b}");
                    break;
                case "/":
                    if (b > 0) {
                        Console.WriteLine($"{a} + {b} = {a / b}");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
           
    }
    class Program
    {
        static void Main(string[] args)
        {
            Arithmatic s1 = new Arithmatic();
            s1.GetData();
            s1.cal();
            Console.ReadKey();
        }
    }
}
