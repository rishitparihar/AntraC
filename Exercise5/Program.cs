using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{   
    public class Triangle
    {
        int input, flag,temp,toPrint;
        


        public void GetData()
        {
            Console.WriteLine("Enter the Number of Rows: ");
            input = Convert.ToInt32(Console.ReadLine());
        }

        public void output()
        {
            flag = 0;
            temp = 1;
            for (int i = 1; i <= input; i++)
                flag = i;
            {
                for (int j = 0; j < flag; j++)
                {
                    toPrint = temp % 2;
                    Console.Write(toPrint);
                    temp += 1;
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle s1 = new Triangle();
            s1.GetData();
            s1.output();
            Console.ReadKey();
        }
    }
}
