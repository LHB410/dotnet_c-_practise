using System;
using Internal;

namespace Randomcase
{
  class program
  {

    static void Main(string[] args)
    {

        Random random = new Random();

        //Console user input
        Console.WriteLine("Please input the string to be randomized:");
        string myString = Console.ReadLine();

        //Split the string and put it into a char array
        char[] upChar = myString.ToCharArray();
        string randChar = "";

        for (int i = 0; i <= upChar.Length - 1; i++)
        {
            //Generate a random number with every new iteration
            int num = random.Next(myString.Length);
            //Extract from the input string just one character begining at the random generated number
            randChar = myString.Substring(num, 1);
            //Take the extracted character and make it upper case
            randChar = randChar.ToUpper();
            //Convert back to char and put it into the initial array at the same posito
            upChar[num] = randChar.ToCharArray()[0];
        }

        Console.WriteLine("There you go:");

        for (int i = 0; i <= upChar.Length - 1; i++)
        {
            Console.Write(upChar[i]);
        }

            //Keep the console on screen until user presses enter
            Console.ReadLine();




        }
    }
}
