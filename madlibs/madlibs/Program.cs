using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program runs a mad lib game by taking user input and interpolates the words into the blanks
            Author: laura brooks
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Game is running!");

            // Give the Mad Lib a title:
            string title = "Laura's Day Out";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            // asking for 3  adjectives
            Console.Write("Enter 3 adjectives, an adjective is a word that describes a noun, like a color (‘blue’), or feeling (‘silly’), texture (‘soft’).\n ");
            Console.Write("Adjective 1: ");
            string adj1 = Console.ReadLine();
            Console.Write("Adjective 2: ");
            string adj2 = Console.ReadLine();
            Console.Write("Adjective 3: ");
            string adj3 = Console.ReadLine();

            // asking user for 3 verbs
            Console.Write("Enter a verb, a verb is a word that represents an action, like ‘sit’, ‘eat’, ‘sleep’.\n");
            Console.Write("Verb: ");
            string verb = Console.ReadLine();

            // asking user for 2 nouns
            Console.Write("Enter 2 nouns, a noun is a person (‘girl’), place (‘cabin’), or thing (‘toaster’).\n");
            Console.Write("Noun 1: ");
            string noun1 = Console.ReadLine();
            Console.Write("Noun 2: ");
            string noun2 = Console.ReadLine();

            // enter wild card variables
            Console.Write("Enter 1 of each of the following: \n An Animal: ");
            string animal = Console.ReadLine();
            Console.Write("A food: ");
            string food = Console.ReadLine();
            Console.Write("A fruit: ");
            string fruit = Console.ReadLine();
            Console.Write("A superhero: ");
            string superhero = Console.ReadLine();
            Console.Write("A country: ");
            string country = Console.ReadLine();
            Console.Write("A dessert: ");
            string dessert = Console.ReadLine();
            Console.Write("A year: ");
            string year = Console.ReadLine();




            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.Write(story);
        }
    }
}
