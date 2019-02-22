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

        public string Age;



        public void Speak()

        {

            Console.WriteLine("My name is " + this.Name + " and I am " + this.Color + this.Age);

        }



    }



    class Red : Dog

    {

        public Red(string name) : base(name)

        {

            this.Color = "Brown";
            this.Age = " 5 months old";
            this.Speak();

        }

    }



    class Blue : Dog

    {

        public Blue(string name) : base(name)

        {

            this.Color = "Pink";
            this.Age = " 1 year and 2 months old";
            this.Speak();

        }

    }



    class Green : Dog

    {

        public Green(string name) : base(name)

        {

            this.Color = "White";
            this.Age = " 3 months old";
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
                    Console.WriteLine("Type in the number of the dog that you want to check out");
                    string dog1 = Console.ReadLine();
                    if (dog1 == "1")
                    {
                        Dog a = new Red("Corgi");
                        Console.WriteLine("If you want this dog type in + if you want to check another dog press -");
                        string accept = Console.ReadLine();
                        if (accept == "+")
                        {
                            Console.WriteLine("Have a good day with your new friend ;)");
                            Console.ReadKey();
                        }
                        else
                        {
                            goto Start1;
                        }
                  

                    }
                    else if (dog1 == "2")
                    {
                        Dog b = new Blue("Labrador");
                        Console.WriteLine("If you want this dog type in + if you want to check another dog press -");
                        string accept = Console.ReadLine();
                        if (accept == "+")
                        {
                            Console.WriteLine("Have a good day with your new friend ;)");
                            Console.ReadKey();
                        }
                        else
                        {
                            goto Start1;
                        }

                    }
                    else if (dog1 == "3")
                    {
                        Dog c = new Green("Husky");
                        Console.WriteLine("If you want this dog type in + if you want to check another dog press -");
                        string accept = Console.ReadLine();
                        if (accept == "+")
                        {
                            Console.WriteLine("Have a good day with your new friend ;)");
                            Console.ReadKey();
                        }
                        else
                        {
                            goto Start1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Have you typed in the correct number?");
                        Console.ReadLine();
                        goto Start1;
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
