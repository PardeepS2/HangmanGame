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
        static bool wordFound;
        static char selectedchar;
        static bool over = true;
        static int asciivalue = 0;  // value can be between 0 to 25
        static bool[] usedLetters = new bool[26];
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tLet's Play Hangman");
            Console.WriteLine("\t\t==================");

            Generateword();

            hiddenword();
            Askuser();


            while (over)
            {
                Console.Clear();


              //  hiddenword();
                if(!wordFound)
                PrintHangman();
                //CheckLetterIfInWork
                if (chances > 0)
                {
                    Askuser();
                }
                else {
                    over = false;
                }


                //Console.ReadKey();
            }


            Console.ReadKey();

        }

        public static void Generateword() // metod to generate random word from the given array
        {

            string[] listofwords = { "guitar", "saxophone", "trumpet", "xylophone",
                                      "accordion", "harmonica", "melodica", "sitar" };

            selectedword = listofwords[rnd.Next(0, listofwords.Length)];
        }

        public static void PrintHangman() // build hangman
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
                default:
                    break;


            }
        }
        public static void hiddenword()
        {
            for (int i = 0; i < selectedword.Length; i++)
            {
                char l = selectedword[i];
                asciivalue = l - 'a';
                if (usedLetters[asciivalue] == true)
                {
                    Console.Write(l + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine();
        }

        public static void Askuser()
        {
            Console.WriteLine("Please enter one letter");
            char selectedchar = Convert.ToChar(Console.ReadLine());
            asciivalue = selectedchar - 'a';
            usedLetters[asciivalue] = true;
            for (int position = 0; position < selectedword.Length; position++)
            {
                if (selectedchar == selectedword[position])
                {
                    hiddenword();
                    wordFound = true;
    
                }
               
              

            }
            if (wordFound == false)
            {
                chances--;
              

               

            }








        }
    }
}
