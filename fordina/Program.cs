using System;
using fordina.LevelOfGrumpiness;
using fordina.Grandpa;
using System.Threading;

namespace fordina
{
    public class Program
    {
        /// <summary>
        /// Выводит массив из 20 случайных чисел и меняет 2 введенных числа местами
        /// </summary>
        /// <returns>итоговый масссив</returns>
        public static int[] Task1()
        {
            Random rand = new Random();
            int[] array = new int[20];
            for (var i = 0;  i < array.Length; i++)
            {
                array[i] = rand.Next();
            }
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine("Введите 2 числа из этого списка, которые вы хотите поменять местами(ввод через Enter):");
            bool isNum1 = int.TryParse(Console.ReadLine(), out int num1);
            bool isNum2 = int.TryParse(Console.ReadLine(), out int num2);
            if (!isNum1 || !isNum2)
            {
                Console.WriteLine("Введены неккоректные значения, нечего менять");
                return array;
            }
            int index1 = Array.IndexOf(array, num1);
            int index2 = Array.IndexOf(array, num2);
            int isIndex = -1;
            if(index1 == isIndex || index2 == isIndex)
            {
                Console.WriteLine("Введенных чисел нет, нечего менять");
                return array;
            }
            int mediumValue = array[index1];
            array[index1] = array[index2];
            array[index2] = mediumValue;
            return array;
        }
        /// <summary>
        /// Сохраняет в первую переданную переменную произведение всех чисел, а во вторую среднее арифметическое, возвращает сумму переданных целых чисел
        /// </summary>
        /// <param name="composition"></param>
        /// <param name="arithmeticMean"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Task2(ref int composition, out float arithmeticMean, params int[] array)
        {
            composition = 1;
            int sum = 0;
            foreach (var i in array)
            {
                composition *= i;
                sum += i;
            }
            arithmeticMean = sum / array.Length;
            return sum;
        }
        /// <summary>
        /// Выводит введенное число, если оно от 1 до 9
        /// </summary>
        /// <exception cref="Exception">Ошибка ввода</exception>
        public static void Task3()
        {
            Console.WriteLine("Введите число или команду для выхода(exit/закрыть):");
            string input = Console.ReadLine();
            if (input.ToLower() == "закрыть" || input == "exit")
            {
                return;
            }
            
            if (!int.TryParse(input, out int number))
            {
                throw new Exception("Введенна неккоректная команда или число");
            }
            if (number >= 0 && number <= 9)
            {
                HelpTask3(number);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Thread.Sleep(3000);
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("Введенное число выходит из диапозона от 0 до 9! ");
            }

        }
        /// <summary>
        /// Выводит переданное число
        /// </summary>
        /// <param name="number">Число, которое нужно напечатать</param>
        public static void HelpTask3(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine
                       ("  #\n" +
                        " ##\n" +
                        "# #\n" +
                        "  #\n" +
                        "  #");
                    break;
                case 0:
                    Console.WriteLine
                       ("###\n" +
                        "# #\n" +
                        "# #\n" +
                        "###");
                    break;
                case 2:
                    Console.WriteLine
                       ("###\n" +
                        "  #\n" +
                        "###\n" +
                        "#  \n" +
                        "###");
                    break;
                case 3:
                    Console.WriteLine
                       ("###\n" +
                        "  #\n" +
                        "###\n" +
                        "  #\n" +
                        "###");
                    break;
                case 4:
                    Console.WriteLine
                       ("# #\n" +
                        "# #\n" +
                        "###\n" +
                        "  #\n" +
                        "  #");
                    break;
                case 5:
                    Console.WriteLine
                       ("###\n" +
                        "#  \n" +
                        "###\n" +
                        "  #\n" +
                        "###");
                    break;
                case 6:
                    Console.WriteLine
                       ("###\n" +
                        "#  \n" +
                        "###\n" +
                        "# #\n" +
                        "###");
                    break;
                case 7:
                    Console.WriteLine
                       ("###\n" +
                        "  #\n" +
                        "  #\n" +
                        "  #\n" +
                        "  #");
                    break;
                case 8:
                    Console.WriteLine
                       ("###\n" +
                        "# #\n" +
                        "###\n" +
                        "# #\n" +
                        "###");
                    break;
                case 9:
                    Console.WriteLine
                       ("###\n" +
                        "# #\n" +
                        "###\n" +
                        "  #\n" +
                        "###");
                    break;  
            }
        }
        public static void Main(string[] args)
        {
            //Номер 1
            Console.WriteLine("1. Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого\r\n" +
                "массива, которые нужно поменять местами. Вывести на экран получившийся\r\nмассив.");
            Console.WriteLine(string.Join(", ", Task1()));
            //Номер 2
            Console.WriteLine("2. Написать метод, где в качества аргумента будет передан массив (ключевое слово\r\n" +
                "params). Вывести сумму элементов массива (вернуть). Вывести (ref) произведение\r\n" +
                "массива. Вывести (out) среднее арифметическое в массиве.");
            int composition = 0;
            Console.WriteLine(Task2(ref composition, out float arithmeticMean, 1, 2, 2, 5, 6, 7, 5, 4, 5, 7, 8, 9));
            Console.WriteLine(composition);
            Console.WriteLine(arithmeticMean);
            //Номер 3
            Console.WriteLine("3. Пользователь вводит числа. Если числа от 0 до 9, то необходимо в консоли нарисовать\r\n" +
                "изображение цифры в виде символа #.Если число больше 9 или меньше 0, то консоль\r\n" +
                "должна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке.\r\n" +
                "Если пользователь ввёл не цифру, то программа должна выпасть в исключение.\r\n" +
                "Программа завершает работу, если пользователь введёт слово: exit или закрыть (оба\r\nварианта должны сработать) - консоль закроется.");
            Task3();
            //Номер 4
            Console.WriteLine("4. Создать структуру Дед. У деда есть имя, уровень ворчливости (перечисление), массив\r\n" +
                "фраз для ворчания (прим.: “Проститутки!”, “Гады!”), количество синяков от ударов\r\n" +
                "бабки = 0 по умолчанию. Создать 5 дедов. У каждого деда - разное количество фраз\r\n" +
                "для ворчания. Напишите метод (внутри структуры), который на вход принимает деда,\r\n" +
                "список матерных слов (params). Если дед содержит в своей лексике матерные слова из\r\n" +
                "списка, то бабка ставит фингал за каждое слово. Вернуть количество фингалов.");
            Granddad granddad1 = new Granddad("Alex", Grumpiness.VeryLow, new string[] {"какашка", "черт", "сволочь"}, 2);
            Granddad granddad2 = new Granddad("Sasha", Grumpiness.Tall, new string[] { "урод", "черт", "проститутка" }, 10);
            Granddad granddad3 = new Granddad("Dima", Grumpiness.Low, new string[] { "какашка", "наркоман", "алкаш" }, 5);
            Granddad granddad4 = new Granddad("Anton", Grumpiness.VeryTall, new string[] { "свинья", "петух", "черт" }, 25);
            Granddad granddad5 = new Granddad("Maxim", Grumpiness.Average, new string[] { "фигня", "пес", "сволочь" }, 8);
            Console.WriteLine(Granddad.PhrasesCheck(granddad3, "петух", "фигня", "черт", "алкаш"));
        }
    }
}
