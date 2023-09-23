using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        // Вызываем функцию, которая находит и печатает слова, встречающиеся один раз
        PrintUniqueWords(input);
    }

    static void PrintUniqueWords(string input)
    {
        // Разбиваем строку на слова, разделенные пробелами, и удаляем пустые элементы
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Создаем словарь для подсчета встречающихся слов
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        // Подсчитываем количество вхождений каждого слова в строке
        foreach (string word in words)
        {
            // Приводим слово к нижнему регистру, чтобы учитывать регистронезависимые совпадения
            string lowercaseWord = word.ToLower();

            if (wordCount.ContainsKey(lowercaseWord))
            {
                // Увеличиваем счетчик, если слово уже есть в словаре
                wordCount[lowercaseWord]++;
            }
            else
            {
                // Добавляем слово в словарь, если оно встречается впервые
                wordCount[lowercaseWord] = 1;
            }
        }

        // Печатаем только слова, которые встречаются один раз
        Console.WriteLine("Слова, встречающиеся один раз в строке:");

        foreach (var pair in wordCount)
        {
            if (pair.Value == 1)
            {
                Console.WriteLine(pair.Key);
            }
        }
    }
}
