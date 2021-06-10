using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Diamond
    {
        int input, flag;
        String ToPrint;

        public void GetData()
        {
            Console.WriteLine("Enter the Number of Rows: ");
            input = Convert.ToInt32(Console.ReadLine());
        }

        public void output()
        {
            ToPrint = "*";
            flag = 1;
            
            for (int i = 1; i <= input; i++)
            {
                for (int j = 0; j < flag; j++)
                {
                    Console.Write(ToPrint);
                }
                Console.WriteLine();
                flag += 2;

            }

            flag -= 2;

            for (int i = 1; i < input; i++)
            {
                for (int j = 0; j < flag; j++)
                {
                    Console.Write(ToPrint);
                }
                Console.WriteLine();
                flag -= 2;

            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Diamond s1 = new Diamond();
            s1.GetData();
            s1.output();
            Console.ReadKey();
        }
    }
}
