using System;

namespace AQA
{
    ///Create a general cat class 
    ///create a smurf cat class
    ///create main class and cats Bilbo, Smeagul, Sam
    public class Cat 
        {
        string name;
        string colour;
        int born;

      class SmurfCat : Cat
        {
            public SmurfCat()
            {
            Console.WriteLine("I am a special class of Smurf cats");
            }
        }
///make names of cats
        static void Main(string[] args)
        {
            Cat Bilbo = new Cat();
            Bilbo.name = "Bilbo";
            Bilbo.colour = "Brown";
            Bilbo.born = 2890;

            Cat Smegol = new Cat();
            Smegol.name = "Smegol";
            Smegol.colour = "green";
            Smegol.born = 2430;

            Cat Sam = new Cat();
            Sam.name = "Samwise";
            Sam.colour = "red";
            Sam.born = 2980;

            Console.WriteLine(" Hello, my name is " + Bilbo.name + " I was born in the year of " + Bilbo.born + " And my haircolour is " + Bilbo.colour);
            Console.WriteLine(" Hello, my name is " + Smegol.name + " I was born in the year of " + Smegol.born + " And my haircolour is " + Smegol.colour);
            Console.WriteLine(" Hello, my name is " + Sam.name);
        }
    }
}