using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class WordsNullException : Exception
    {
        public WordsNullException(string message) : base(message) { }
    }
    internal class Strings
    {


        public static void FunctionWordsCount()
        {



            string input = "Hello World";

            var wordsCount = GetWordsCount(input);


            Console.WriteLine($"Количество слов - {wordsCount}");
        }

        public static int GetWordsCount(string words)
        {
            string[] wordsArray = words.Split(' ');

            return wordsArray.Length;

        }
        public static void PrintWords(string[] words)
        {
            foreach (string i in words)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }



        public static List<string> GetTextList(string[] wordsArray)
        {
            List<string> result = new List<string>();
            foreach (string word in wordsArray)
            {
                result.Add(word);
            }
            return result;


        }
        //Задание.
        //Создать функцию для замены в тексте заданного слова на звёздочки (количество звёздочек должно соответствовать количеству букв в слове). 
        //    Функция должна проверять передаваемое слово, если оно пустое или из одних пробелов - то выбрасывать исключение.


        public static void FunctionReplace()
        {
            var text = ReplaceWords2("Hello World", "World");
            Console.WriteLine(text);
        }
        public static string ReplaceWords(string text, string currentWord)
        {
            string[] words = text.Split(' ');

            string star = "";
            for (int i = 0; i < currentWord.Length; i++)
            {
                star += "*";
            }


            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == currentWord)
                {
                    words[i] = star;
                }
            }

            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                result += words[i] + " ";
            }
            return result;
            // Пункт 1 - Разделить слова пробелом
            // Пункт 2 - Найти слова исключение  и заменить на * 
            // Пункт 3 - Собрать текст  и вернуть его

        }

        public static string ReplaceWords2(string text, string currentWord)
        {
            string star = "";
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (currentWord == null && currentWord == " ")
                {
                    throw new WordsNullException($"Пустое значение {currentWord}");
                }
                star += "*";

            }

            string result = text.Replace(currentWord, star);

            return result;
        }

    }


}


