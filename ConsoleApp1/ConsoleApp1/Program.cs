using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoptions
{
    class Adoption
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to adoption center, whats your name? : ");
            string human = Console.ReadLine();
            Console.WriteLine("Hello " + human);
            {
            Start:
                Console.Write("What animal do you prefer? (Dog or Cat) : ");
                string answer1 = Console.ReadLine();

                if (answer1 == "Dog")
                {
                    Console.WriteLine("Oh okey you want a " + answer1 + " let's see what we have here");
                    Console.WriteLine("This is what we have "); //+ Dog1 + Dog2 + Dog3 + Dog4);
                    Console.ReadLine();
                }

                else if (answer1 == "Cat")
                {
                    Console.WriteLine("Oh okey you want a " + answer1 + " let's see what we have here");
                    Console.WriteLine("This is what we have "); //+ Cat1 + Cat2 + Cat3 + Cat4);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect typing");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    Console.ReadKey();
                    goto Start;
                }




            }
        }
    }
}
