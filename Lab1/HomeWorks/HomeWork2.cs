using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab1.HomeWorks
{
    /// <summary>
    /// Методы обработки строк.
    /// Исходные условия: Метод принимает исходный массив строк, и возвращает результат обработки
    /// </summary>
    public class HomeWork2
    {
        /// <summary>
        /// Найти самую короткую и самую длинную строки. Вернуть найденные строки и их длину.
        /// </summary>
        /// <param name="temp">Исходный массив строк</param>
        /// <returns>Самая длинная строка, ее длина, самая маленькая трока и ее длина. Пример вывода return ("max1", 4, "min", 3);</returns>
        public static (string max, int lengthMax, string min, int lengthMin) Variant1(string[] temp)
        {
            var orderedList = temp.OrderBy(x => x.Length);
            var min = orderedList.First();
            var max = orderedList.Last();
            var lengthMax = max.Length;
            var lengthMin = min.Length;
            return (max, lengthMax, min, lengthMin);
        }

        /// <summary>
        /// Найти слово, состоящее только из цифр. Если таких слов больше одного, найти второе из них
        /// </summary>
        /// <param name="temp">Исходный массив строк</param>
        /// <returns>Слово состоящее только из цифр.</returns>
        public static string Variant2(string[] temp)
        {
            var numericText = temp.Where(x => Array.TrueForAll(x.ToCharArray(), Char.IsDigit));
            return numericText.Last();
        }
    }
}