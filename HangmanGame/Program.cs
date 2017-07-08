using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tLet's Play Hangman");
            Console.WriteLine("\t\t==================");
            int chances = 5;
            Generateword();
            Console.ReadKey();

        }
        public static void Generateword() // choose random word from the given array
        {
            string word;
            Random rnd = new Random();
            string[] listofwords = { "guitar", "saxophone", "trumpet", "xylophone",
                                      "accordion", "harmonica", "melodica", "sitar" };
            word = listofwords[rnd.Next(0, listofwords.Length)];
            Console.WriteLine(word);
        }


    }
}
