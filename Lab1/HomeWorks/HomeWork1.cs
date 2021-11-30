using System;
using System.Linq;

namespace Lab1.HomeWorks
{
    /// <summary>
    /// Методы обработки массива.
    /// Исходные условия: Метод принимает исходный массив, и возвращает результат обработки
    /// </summary>
    public static class HomeWork1
    {
        /// <summary>
        /// В массиве целых чисел поменять местами максимальный отрицательный элемент и минимальный положительный.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором поменяны местами максимальный отрицательный элемент и минимальный положительный</returns>
        public static int[] Variant1(int[] temp)
        {
            int superNegative = 0;
            int minPositive = int.MaxValue;
            foreach (int a in temp)
            {
                if (a < 0 && a < superNegative)
                {
                    superNegative = a;
                }
                else if (a > 0 && a < minPositive)
                {
                    minPositive = a;
                }
            }
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == superNegative)
                {
                    temp[i] = minPositive;
                }
                else if (temp[i] == minPositive)
                {
                    temp[i] = superNegative;
                }
            }
            int tempElement = superNegative;
            superNegative = minPositive;
            minPositive = tempElement;
            for (int i = 0; i < temp.Length; i++) ;
            return temp;
        }
        /// <summary>
        /// В массиве целых чисел определить сумму элементов, состоящих на чётных позициях
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Сумма элементов, состоящих на чётных позициях массива</returns>
        public static int Variant2(int[] temp)
        {
            int result = 0;
            for (int i = 2; i < temp.Length; i += 2)
            { result += temp[i]; }
            return result;
        }

        /// <summary>
        /// В массиве целых чисел заменить нулями отрицательные элементы.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором поменяны отрицательные элементы на нули</returns>
        public static int[] Variant3(int[] temp)
        {
            for (int i = 0; i < temp.Length; i++)
                if (temp[i] < 0) temp[i] = 0;
            return temp;
        }

        /// <summary>
        /// В массиве целых чисел утроить каждый положительный элемент, который стоит перед отрицательным.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором *3 каждый положительный элемент, который стоит перед отрицательным</returns>
        public static int[] Variant4(int[] temp)
        {
            for (int i = 0; i < temp.Length; i++)

            {
                if (temp[i] > 0 && temp[i + 1] < 0 && i <= temp.Length)
                {
                    temp[i] *= 3;

                }
            }
            return temp;
        }


        /// <summary>
        /// В массиве целых чисел найти разницу между средним арифметическим и значение минимального элемента.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Разница между средним арифметическим и значение минимального элемента</returns>
        public static double Variant5(int[] temp)
        {
            double avg = temp.Average();
            int min = temp.Min();
            return avg - min;
        }
    }
}