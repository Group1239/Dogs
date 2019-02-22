using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoptions
{
    class Dog

    {

        public Dog(string name)

        {

            this.Name = name;

        }

        public string Name;

        public string Color;



        public void Speak()

        {

            Console.WriteLine("My name is " + this.Name + " and I am " + this.Color);

        }



    }



    class Corgi : Dog

    {

        public Corgi(string name) : base(name)

        {

            this.Color = "Red";

            this.Speak();

        }

    }



    class Labrador : Dog

    {

        public Labrador(string name) : base(name)

        {

            this.Color = "Blue";
            this.Speak();

        }

    }



    class Husky : Dog

    {

        public Husky(string name) : base(name)

        {

            this.Color = "Green";
            
            this.Speak();

        }

    }
       
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
                    Start1:
                    Console.WriteLine("This is what we have Corgi number 1; Labrador number 2; Husky number 3");
                    string dog1 = Console.ReadLine();
                    if (dog1 == "1")
                    {
                        Dog
                    }
                    else if (dog1 == "2")
                    {
                        Dog
                    }
                    else if (dog1 == "3")
                    {
                        Dog
                    }
                    else
                    {
                        Console.WriteLine("Have you typed in the correct number?");
                    }

                }
                else if (answer1 == "Cat")
                {
                    Console.WriteLine("Oh okey you want a " + answer1 + " let's see what we have here");
                    Console.WriteLine("This is what we have "); //+ Cat1 + Cat2 + Cat3 + Cat4);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect typing or we don't have that type of animal, choose from the given options");
                    Console.WriteLine("Let's try again ");
                    Console.WriteLine("Press Enter key to continue");
                    Console.ReadKey();
                    goto Start;
                }
            }
        }
    }
   
}
