using System;

namespace homework4
{
    public class Program
    {

        /// <summary>
        /// Определет большее из двух чисел
        /// </summary>
        /// <param name="number1">Первое число</param>
        /// <param name="number2">Второе число</param>
        /// <returns>Большее из чисел</returns>
        public static int Task51(int number1, int number2)
        {
            Console.WriteLine("Упражнение 5.1 Написать метод, возвращающий наибольшее из двух чисел. Входные\r\n" +
                "параметры метода – два целых числа. Протестировать метод.");
            return number1 >= number2 ? number1 : number2;
        }
        /// <summary>
        /// Меняет местами значения переменных
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        public static void Task52(ref int a, ref int b)
        {
            Console.WriteLine("Упражнение 5.2 Написать метод, который меняет местами значения двух передаваемых\r\n" +
                "параметров. Параметры передавать по ссылке. Протестировать метод.");
            int mediumValue = a;
            a = b;
            b = mediumValue;
        }
        /// <summary>
        /// Вычисляет факториал вводимого числа (для положительных чисел и с учетом переполнения)
        /// </summary>
        /// <param name="num">число, факториал которого нужно посчитать</param>
        /// <param name="result">значение факториала(если неккоректное число или переполнение то равно 0)</param>
        /// <returns>удалось найти значение или нет</returns>
        public static bool Task53(int num, out long result)
        {
            Console.WriteLine("Упражнение 5.3 Написать метод вычисления факториала числа, результат вычислений передавать в выходном параметре." +
                "Если метод отработал успешно, то вернуть значение true;" +
                " если в процессе вычисления возникло переполнение, то вернуть значение false." +
                "Для отслеживания переполнения значения использовать блок checked.");
            result = 1;
            if (num < 0)
            {
                return false;
            }
            try
            {
                checked
                {
                    for (var i = 1; i < num; i++)
                    {
                        result *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                result = 0;
                return false;
            }
            
        }
        /// <summary>
        /// Вычисляет факториал числа рекурсивным методом
        /// </summary>
        /// <param name="number">Число, факториал которого нужно найти</param>
        /// <returns>Значение факториала</returns>
        public static long Task54(int number)
        {
            if (number < 0)
            {
                return 0;
            }
            long result = 0;
            try
            {
                checked
                {
                    result = number * Task54(number - 1);
                }
                return result;
            }
            catch(OverflowException)
            {
                return 0;
            }
        }
        /// <summary>
        /// Находит НОД для 2 натуральных чисел
        /// </summary>
        /// <param name="number1">Первое число</param>
        /// <param name="number2">Второе число</param>
        /// <returns>НОД</returns>
        public static int Task51forHomeWork(int number1, int number2)
        {
            while (number2 != 0)
            {
                int mediumValue = number2;
                number2 = number1 % number2;
                number1 = mediumValue;
            }
            return number1;
        }
        /// <summary>
        /// Находит НОД для 3 чисел
        /// </summary>
        /// <param name="number1">Первое число</param>
        /// <param name="number2">Второе число</param>
        /// <param name="number3">Третье число</param>
        /// <returns>НОД</returns>
        public static int Task51forHomeWork(int number1, int number2, int number3)
        {
            return Task51forHomeWork(Task51forHomeWork(number1, number2), number3);
        }
        /// <summary>
        /// находит значение заданного номера из ряда чисел Фиббоначи
        /// </summary>
        /// <param name="number">значение какого номера из чисел Фибонначи нужно</param>
        /// <returns>значение числа</returns>
        public static long Task52forHomeWork(int number)
        {
            try
            {
                if (number < 0)
                {
                    throw new ArgumentException();
                }
                if (number == 0)
                {
                    return 0;
                }
                if (number == 1)
                {
                    return 1;
                }
                return Task52forHomeWork(number - 1) + Task52forHomeWork(number - 2);
            }
            catch (ArgumentException)
            {
                return 0;
            }
        }
        public static void Main(string[] args)
        {
            //Тест 5.1
            Console.WriteLine(Task51(2, 3));
            //Тест 5.2
            int num1 = 12;
            int num2 = 15;
            Task52(ref num1, ref num2);
            Console.WriteLine($"{num1}, {num2}");
            //Номер 5.4
            Console.WriteLine("Упражнение 5.4 Написать рекурсивный метод вычисления факториала числа.");
            //номер 5.1 из дз
            Console.WriteLine("Домашнее задание 5.1 Написать метод, который вычисляет НОД двух натуральных чисел\r\n" +
                "(алгоритм Евклида). Написать метод с тем же именем, который вычисляет НОД трех\r\nнатуральных чисел.");
            Console.WriteLine(Task51forHomeWork(36, 54));
            Console.WriteLine(Task51forHomeWork(18, 36, 54));
            //Номер 5.2 из дз
            Console.WriteLine("Домашнее задание 5.2 Написать рекурсивный метод, вычисляющий значение n-го числа\r\n" +
                "ряда Фибоначчи. Ряд Фибоначчи – последовательность натуральных чисел 1, 1, 2, 3, 5, 8,\r\n" +
                "13... Для таких чисел верно соотношение Fk = Fk-1 + Fk-2 .");
            Console.WriteLine(Task52forHomeWork(10));

        }
    }
}
