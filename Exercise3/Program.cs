using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Reservestring
    {
        String input;

        public void GetData()
        {
            Console.WriteLine("Enter string");
            input = Console.ReadLine();
        }

        public void output()
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Reservestring s1 = new Reservestring();
            s1.GetData();
            s1.output();
            Console.ReadKey();
        }
    }
}
