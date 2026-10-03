using System;

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
        public static void Task2()
        {

        }
        public static void Main(string[] args)
        {
            //Номер 1
            Console.WriteLine("1. Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого\r\n" +
                "массива, которые нужно поменять местами. Вывести на экран получившийся\r\nмассив.");
            Console.WriteLine(string.Join(", ", Task1()));
        }
    }
}
