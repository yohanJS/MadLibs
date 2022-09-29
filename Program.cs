using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Mad Libs are short stories with blanks for the player to fill in that represent different parts of speech. The end result is a really hilarious and strange story....
            Unknown: ...
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Mad Libs program is now running....");

            // Give the Mad Lib a title:
            string title = "Mad Libs and C# are a lot of fun.";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter three adjectives in this order:\n1-color:\n2-feeling:\n3-texture: ");
            string color = Console.ReadLine();
            string feeling = Console.ReadLine();
            string texture = Console.ReadLine();

            Console.WriteLine("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.WriteLine("Enter two nouns in this order:\nNoun One:\nNoun Two:");
            string nounOne = Console.ReadLine();
            string nounTwo = Console.ReadLine();

            Console.WriteLine("Enter one of the following in this order:");
            Console.WriteLine("An animal:");
            string animal = Console.ReadLine();

            Console.WriteLine("A food:");
            string food = Console.ReadLine();

            Console.WriteLine("A fruit:");
            string fruit = Console.ReadLine();

            Console.WriteLine("A superhero:");
            string superHero = Console.ReadLine();

            Console.WriteLine("A country:");
            string country = Console.ReadLine();

            Console.WriteLine("A dessert:");
            string dessert = Console.ReadLine();

            Console.WriteLine("A year:");
            string year = Console.ReadLine();



            // The template for the story:

            string story = $"This morning {name} woke up feeling {color}. 'It is going to be a {feeling} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {fruit}s very {texture}. Concerned, {name} texted {superHero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}
