using System;
using System.Text;
using System.Collections.Generic;

namespace LinkedListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application uses Linked Lists collection to demonstrate my capabilities :)");
            Console.WriteLine();

            string[] words = { "age", "is", "just", "an", "illusion", "of", "time" };

            LinkedList<string> sentence = new LinkedList<string>(words);
            
            //Display entire list
            Display(sentence, "[Test 1] - Display all words:: ");

        }

        private static void Display(LinkedList<string> words, string test)
        {
            Console.Write(test);

            foreach (string word in words)
            {
                Console.Write(word + " ");
            }

            Console.ReadLine();
        }

        private static void Reverse(LinkedList<string> words, string test)
        {
            Console.Write(test);


        }
    }
}
