using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter product name");
            string a = Console.ReadLine();

            Console.WriteLine("Enter the quantity of the product");
            int ab = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Price");
            int ac = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter product name");
            string b = Console.ReadLine();

            Console.WriteLine("Enter the quantity of the product");
            int bb = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Price");
            int bc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter product name");
            string c = Console.ReadLine();

            Console.WriteLine("Enter the quantity of the product");
            int cb = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Price");
            int cc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************");

            int itog = ab * ac + bb * bc + cb * cc;

            if (itog < 1000)
            {
                Console.WriteLine("Shop 'AT HOME'");
                Console.WriteLine("Moscow, Pushkina str., 12");
                Console.WriteLine("Your service: Ivanova Larisa");
                Random random = new Random();
                int r;
                r = random.Next(1000000000);
                Console.WriteLine("Check № " + r);
                Console.WriteLine("********************************");
                Console.WriteLine("Product |" + "Amount |" + "Price");
                Console.WriteLine(a +     "|" + ab        +"|" + ac);
                Console.WriteLine(b +     "|" + bb        +"|" + bc);
                Console.WriteLine(c +     "|" + cb        +"|" + cc);
                Console.WriteLine("Total = " + itog);
                Console.WriteLine("Your discount is 2%.");
                int skidka_2 = itog - itog * 2 / 100;
                Console.WriteLine("The amount to pay is = " + skidka_2);
                Console.WriteLine("Deposit cash = ");
                int nal = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("********************************");

                int sdacha = nal - skidka_2;
                Console.WriteLine("Your change = " + sdacha);

                Console.WriteLine("********************************");
            }

            if (itog > 1000)
            {
                Console.WriteLine("Shop 'AT HOME'");
                Console.WriteLine("Moscow, Pushkina str., 12");
                Console.WriteLine("Your service: Ivanova Larisa");
                Random random = new Random();
                int r;
                r = random.Next(1000000000);
                Console.WriteLine("Check № " + r);
                Console.WriteLine("********************************");
                Console.WriteLine("Product |" + "Amount |" + "Price");
                Console.WriteLine(a + "|" + ab + "|" + ac);
                Console.WriteLine(b + "|" + bb + "|" + bc);
                Console.WriteLine(c + "|" + cb + "|" + cc);
                Console.WriteLine("Total = " + itog);
                Console.WriteLine("Your discount is 5%");
                int skidka_5 = itog - itog * 5 / 100;
                Console.WriteLine("The amount to pay is = " + skidka_5);
                Console.WriteLine("Deposit cash = ");
                int nal = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("********************************");

                int sdacha = nal - skidka_5;
                Console.WriteLine("Your change = " + sdacha);

                Console.WriteLine("********************************");

            }

            Console.WriteLine("      THANK YOU FOR YOUR PURCHASE!       ");
            Console.WriteLine("             COME AGAIN!!!               ");

            Console.ReadKey();


        }
        
    }
}
