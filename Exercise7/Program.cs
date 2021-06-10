using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public class ATM
    {
        int pin,cash,operator_,change;

        


        public void GetData()
        {
            Console.WriteLine("Enter Your Pin Number");
            pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pin);

            Console.WriteLine("********Welcome to ATM Service **************");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw Cash");
            Console.WriteLine("3. Deposit Cash");
            Console.WriteLine("4. Quit");
            Console.WriteLine("*********************************************");
            Console.WriteLine("Enter your choice:");
            operator_ = Convert.ToInt32(Console.ReadLine());
        }

        public void output()
        {
            cash = 1000;

            switch (operator_)
            {
                case 1:
                    Console.Write("YOU’RE BALANCE IN Rs: ");
                    Console.WriteLine(cash);
                    break;
                case 2:
                    Console.WriteLine("How much to withdraw? ");
                    change = Convert.ToInt32(Console.ReadLine());

                    cash -= change;
                    Console.Write("YOU’RE BALANCE IN Rs: ");
                    Console.WriteLine(cash);
                    break;
                case 3:
                    Console.WriteLine("How much to Deposite? ");
                    change = Convert.ToInt32(Console.ReadLine());

                    cash += change;
                    Console.Write("YOU’RE BALANCE IN Rs: ");
                    Console.WriteLine(cash);
                    break;
                case 4:
                    Console.WriteLine("Thank You");
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
            ATM s1 = new ATM();
            s1.GetData();
            s1.output();
            Console.ReadKey();
        }
    }
}
