using System;
using System.Collections.Generic;

namespace OOP_Character_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            List<characterClass> characters = new List<characterClass>();

            characters.Add(new characterClass("Kaladin", "Honor is Dead but I'll see what I can do", "Life before Dead, Strength before Weakness, Journey before Destination"));
            characters.Add(new characterClass("Tommy Wiseau", "Johnny’s my best friend!", "You’re tearing me apart, Lisa!"));


            // Yes, I know there is a more efficent way to do this, but I'm too lazy to care

            Console.WriteLine($"Primary Catchphrase of {characters[0].name} and {characters[1].name}");
            characters[0].speak(1);
            characters[1].speak(1);

            Console.WriteLine($"Secondary Catchphrase of {characters[0].name} and {characters[1].name}");
            characters[0].speak(2);
            characters[1].speak(2);

            Console.WriteLine($"Original Level of {characters[0].name} and {characters[1].name}");
            Console.WriteLine($"Character 1: {characters[0].level} and Character 2: {characters[1].level}");

            characters[0].setLevel(10);
            characters[1].setLevel(20);

            Console.WriteLine($"New Level of {characters[0].name} and {characters[1].name}");
            Console.WriteLine($"Character 1: {characters[0].level} and Character 2: {characters[1].level}");
        }
    }

    public class characterClass
    {

        public string name;
        public string phrase;
        public string phrase2;
        public int level = 0;

        public characterClass(string getName, string getPhrase, string getPhrase2)
        {
            this.name = getName;
            this.phrase = getPhrase;
            this.phrase2 = getPhrase2;
        }

        public void speak(int phraseSelect)
        {
            switch (phraseSelect)
            {
                case 1:
                    Console.WriteLine(phrase);
                    break;
                case 2:
                    Console.WriteLine(phrase2);
                    break;
                default:
                    Console.WriteLine("This phrase does not exist!");
                    break;
            }
        }

        public void setLevel(int newLevel)
        {
            this.level = newLevel;
        }
    }
}
