using System;

namespace Mad_Libs
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The story is just already started, good luck");
            // Mad Lib title:
            string title = "My first story in C#";

            Console.WriteLine(title);

            // input and variables:
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            Console.Write("Enter adjective number one: ");
            string adj1 = Console.ReadLine();
            Console.Write("Enter adjective number two: ");
            string adj2 = Console.ReadLine();
            Console.Write("Enter adjective number three: ");
            string adj3 = Console.ReadLine();
            Console.Write("Now enter a verb: ");
            string verb = Console.ReadLine();
            Console.Write("Enter a noun word: ");
            string noun1 = Console.ReadLine();
            Console.Write("Enter a second noun word: ");
            string noun2 = Console.ReadLine();
            Console.Write("Now enter an ANIMAL: ");
            string animal = Console.ReadLine();
            Console.Write("Enter a FOOD: ");
            string food = Console.ReadLine();
            Console.Write("Enter a FRUIT: ");
            string fruit = Console.ReadLine();
            Console.Write("Enter a SUPERHERO: ");
            string superh = Console.ReadLine();
            Console.Write("Enter a COUNTRY: ");
            string country = Console.ReadLine();
            Console.Write("Enter a DESSERT: ");
            string dessert = Console.ReadLine();
            Console.Write("Enter a year: ");
            string year = Console.ReadLine();




            // The story template:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superh}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // The story:
            Console.WriteLine(story);
        }
    }
}
