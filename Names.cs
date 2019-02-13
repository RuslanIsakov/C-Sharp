using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("What is your name?");
            string name;
            name = Console.ReadLine();
  
            Console.WriteLine("What is your surname?");
            string surname;
            surname = Console.ReadLine();
     
            Console.WriteLine("How old are you?");
            string age;
            age = Console.ReadLine();
   
            Console.WriteLine("Where do you live?");
            string live;
            live = Console.ReadLine();

            Console.WriteLine("Your name is "+name);
            Console.WriteLine("Your surname is " + surname);
            Console.WriteLine("Your age  " + age);
            Console.WriteLine("You live in " + live);
            
            Console.ReadKey();
           
        }
    }
}
