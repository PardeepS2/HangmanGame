using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    class Program
    {
        static Random rnd = new Random();
        static int chances = 5;
        static string selectedword;  // random word choose by comupter
        static string guessword;
        
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tLet's Play Hangman");
            Console.WriteLine("\t\t==================");
           
            selectedword = Generateword();
            hangman();
            Console.ReadKey();

        }

        public static string Generateword() // metod to generate random word from the given array
        {
            string word;          
            string[] listofwords = { "guitar", "saxophone", "trumpet", "xylophone",
                                      "accordion", "harmonica", "melodica", "sitar" };
            
            word = listofwords[rnd.Next(0, listofwords.Length)];
            return word;
        }

        public static void hangman() // build hangman
        {
            
            switch (chances)
            {
                case 0:
                    Console.WriteLine(" O ");
                    Console.WriteLine("-|-");
                    Console.WriteLine("/ \\ ");
                    Console.WriteLine("GAME OVER!");
                    break;
                case 1:
                    Console.WriteLine(" O ");
                    Console.WriteLine("-|-");
                    Console.WriteLine("/  ");
                    break;
                case 2:
                    Console.WriteLine(" O ");
                    Console.WriteLine("-|-");
                    break;
                case 3:
                    Console.WriteLine(" O ");
                    Console.WriteLine("-|");
                    break;
                case 4:
                    Console.WriteLine(" O ");
                    Console.WriteLine(" |");
                    break;
                case 5:
                    Console.WriteLine("Looking good!");
                    break;

            }
        }

    }
}
