using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoptions
{
    class Animal

    {

        public Animal(string name)

        {

            this.Name = name;

        }

        public string Name;
        public string Age;
        public string Color;



        public void Speak()

        {

            Console.WriteLine("My name is " + this.Name + " my color is " + this.Color + "and I am " + this.Age);

        }



    }



    class Red : Animal

    {

        public Red(string name) : base(name)

        {

            this.Color = " Black ";
            this.Age = " 6 months old";
            this.Speak();

        }

    }



    class Blue : Animal

    {

        public Blue(string name) : base(name)

        {

            this.Color = " Pink ";
            this.Age = " 1 years old";
            this.Speak();

        }

    }



    class Green : Animal

    {

        public Green(string name) : base(name)

        {

            this.Color = " White ";
            this.Age = "1 year and 2 months old";
            this.Speak();

        }

    }

    class Magenda : Animal

    {

        public Magenda(string name) : base(name)

        {
             
            this.Color = "Pink";
            this.Age = " 3 months old";
            this.Speak();

        }

    }

    class Cyan : Animal

    {

        public Cyan(string name) : base(name)

        {

            this.Color = "Purple";
            this.Age = " 7 months old";
            this.Speak();

        }

    }

    class Siamese: Animal

    {

        public Siamese(string name) : base(name)

        {

            this.Color = "Yellow";
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
                    Console.WriteLine("Type in the number of the breed you want to check it out");

                    string dog1 = Console.ReadLine();
                    if (dog1 == "1")
                    {
                        Animal a = new Red("Corgi");
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
                        Animal b = new Blue("Labrador");
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
                        Animal c = new Green("Husky");
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
                        Console.ReadKey();
                        goto Start1;
                    }

                }
                else if (answer1 == "Cat")
                {
                    Console.WriteLine("Oh okey you want a " + answer1 + " let's see what we have here");
                Start2:
                    Console.WriteLine("This is what we have ??????/ number 1; ??????? number 2; ????????? number 3");
                    Console.WriteLine("Type in the number of the breed you want to check it out");
                    string cat1 = Console.ReadLine();
                    if (cat1 == "1")
                    {
                        Animal a = new Red("???????");
                        Console.WriteLine("If you want this dog type in + if you want to check another dog press -");
                        string accept = Console.ReadLine();
                        if (accept == "+")
                        {
                            Console.WriteLine("Have a good day with your new friend ;)");
                            Console.ReadKey();
                        }
                        else
                        {
                            goto Start2;
                        }

                    }
                    else if (cat1 == "2")
                    {
                        Animal b = new Blue("??????");
                        Console.WriteLine("If you want this dog type in + if you want to check another dog press -");
                        string accept = Console.ReadLine();
                        if (accept == "+")
                        {
                            Console.WriteLine("Have a good day with your new friend ;)");
                            Console.ReadKey();
                        }
                        else
                        {
                            goto Start2;
                        }

                    }
                    else if (cat1 == "3")
                    {
                        Animal c = new Green("????????");
                        Console.WriteLine("If you want this dog type in + if you want to check another dog press -");
                        string accept = Console.ReadLine();
                        if (accept == "+")
                        {
                            Console.WriteLine("Have a good day with your new friend ;)");
                            Console.ReadKey();
                        }
                        else
                        {
                            goto Start2;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Have you typed in the correct number?");
                        Console.ReadKey();
                        goto Start2;
                    }
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
