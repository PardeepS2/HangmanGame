using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    class Program
    {
        public static int chances;
        public static String[] words = { "guitar", "saxophone", "trumpet", "xylophone",
                                      "accordion", "harmonica", "melodica", "sitar"};
        static string selectedWord;
        static bool[] usedLetters;
        static int asciiValue;
        static bool repeat = true;

        public static void setVariables()
        {

            chances = 5;
            usedLetters = new bool[26]; //if found is true
            asciiValue = 0; //Can be between 0 to 25

            //Find Random Word
            Random rnd = new Random();
            selectedWord = words[rnd.Next(0, words.Length)];
        }
        static void Main(string[] args)
        {

            setVariables();


            while (repeat)
            {
                Console.Write("Lets Play the Hangman");
                printHangman();
                checkLetterValidation();

                askLetterfromUser();
            }

            Console.ReadKey();
        }

        public static void askLetterfromUser()
        {
            //ASK FOR A LETTER
            Console.Write("Input A Letter: ");

            char selectedCharacter = Convert.ToChar(Console.ReadLine());
            asciiValue = selectedCharacter - 'a';
            usedLetters[asciiValue] = true;

            checkLetterValidation(selectedCharacter);

        }

        public static void checkLetterValidation(char selectedCharacter)
        {

            //CHECK IF LETTER IN WORD
            bool isFound = false;
            for (int position = 0; position < selectedWord.Length; position++)
            {
                if (selectedCharacter == selectedWord[position])
                {
                    isFound = true;
                   /* String[] makeword;
                    string charsStr = "";


                    char[] arr = new char[selectedWord.Length];
                    for (int j = 0; j < arr.Length; j++)
                    {
                        arr[j] = selectedCharacter;

                        charsStr = new string(arr);




                    }
                    if (charsStr == selectedWord)
                    {
                        Console.Write("Yipeeeeeee You Won the Game!: ");
                        repeat = false;

                    }*/




                }
            }

            //IF CORRECT OR NOT
            if (isFound == false)
            {
                chances--;

            }
        }

        public static void checkLetterValidation()
        {
            int count = 0;
            //DRAW MY Hidden Word
            for (int i = 0; i < selectedWord.Length; i++)
            {
                char l = selectedWord[i];
                asciiValue = l - 'a';
                if (usedLetters[asciiValue] == true)
                {
                    Console.Write(l + " ");
                   

                    count++;
                    if (count == selectedWord.Length)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Yipeeeeeee You Won the Game!: ");

                        Console.WriteLine("See you soon!: ");
                        System.Threading.Thread.Sleep(4000);

                        Environment.Exit(0);
                    }
                       

                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine();

        }

        public static void printHangman()
        {

            Console.Clear();
            //Draw HangMan
            Console.WriteLine("Chances " + chances);
            Console.WriteLine("--------------------");



            if (chances == 0)
            {
                DrawLives0();
                repeat = false;
                Console.WriteLine("You Lose!");
                bool repeat_option = true;
                while (repeat_option)
                {
                    Console.WriteLine("Do you Want to Play a game again?(1/0)");
                    int repeatGame = Convert.ToInt32(Console.ReadLine());
                    if (repeatGame == 1)
                    {
                        repeat = true;
                        chances = 5;
                        repeat_option = false;
                        String[] n = { };
                        Main(n);

                    }

                    else if (repeatGame == 0)
                    {
                        repeat = false;
                        repeat_option = false;
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option!");
                        repeat_option = true;
                    }

                }
                Console.Clear();

            }
            else if (chances == 1)
            {
                DrawLives1();
            }
            else if (chances == 2)
            {
                DrawLives2();
            }
            else if (chances == 3)
            {
                DrawLives3();
            }
            else if (chances == 4)
            {
                DrawLives4();
            }
        }

        public static void DrawLives0()
        {
            Console.WriteLine("___________  ");
            Console.WriteLine("|         |  ");
            Console.WriteLine("|         0  ");
            Console.WriteLine("|        /|\\ ");
            Console.WriteLine("|        / \\ ");
            Console.WriteLine("|            ");
            Console.WriteLine("|            ");

        }

        public static void DrawLives1()
        {
            Console.WriteLine("___________  ");
            Console.WriteLine("|         |  ");
            Console.WriteLine("|         0  ");
            Console.WriteLine("|        /|\\ ");
            Console.WriteLine("|          ");
            Console.WriteLine("|            ");
            Console.WriteLine("|            ");

        }

        public static void DrawLives2()
        {
            Console.WriteLine("___________  ");
            Console.WriteLine("|         |  ");
            Console.WriteLine("|         0  ");
            Console.WriteLine("|         | ");
            Console.WriteLine("|          ");
            Console.WriteLine("|            ");
            Console.WriteLine("|            ");

        }
        public static void DrawLives3()
        {
            Console.WriteLine("___________  ");
            Console.WriteLine("|         |  ");
            Console.WriteLine("|         0  ");
            Console.WriteLine("|         | ");
            Console.WriteLine("|          ");
            Console.WriteLine("|            ");
            Console.WriteLine("|            ");

        }
        public static void DrawLives4()
        {
            Console.WriteLine("___________  ");
            Console.WriteLine("|         |  ");
            Console.WriteLine("|         0  ");
            Console.WriteLine("|          ");
            Console.WriteLine("|          ");
            Console.WriteLine("|            ");
            Console.WriteLine("|            ");

        }

    
}
}
