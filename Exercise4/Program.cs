using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class ArmStrong
    {
        int a, b,sum,n,r;
        

        public void GetData()
        {
            Console.WriteLine("Enter a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = Convert.ToInt32(Console.ReadLine());

        }

        public void output()
        {
            for (int i = a; i <= b; i++)
            {
                sum = 0;
                n = i;
                while (n != 0)
                {
                    r = n % 10;
                    sum = sum + (r * r * r);
                    n = n / 10;
                }
                if (i == sum)
                    Console.WriteLine(i);
            }

        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            ArmStrong s1 = new ArmStrong();
            s1.GetData();
            s1.output();
            Console.ReadKey();
        }
    }
}
