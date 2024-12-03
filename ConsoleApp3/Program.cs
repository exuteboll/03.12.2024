using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        /// <summary>
        /// Заполнить одномерный массив с клавиатуры и вывести
        /// </summary>
        /// <returns>возращает</returns>
        static int GetSize()
        {
            Console.Write("Введие размер массива");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) ||size<=0)
            {
                Console.WriteLine("Ошибка");
            }
            return size;
        }
        static int [] Input(int size)
        {
            int[] array = new int[size];
            for(int i = 0;i<size;i++)
            {
                Console.WriteLine($"array[{i}]");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
       static void Output(int []array)
        {
            for(int i = 0;i < array.Length;i++)
            {
                Console.WriteLine($"array [{i}] = {array[i]}");
            }
        
        }
        static void Main(string[] args)
        {
            int size = GetSize();
            int[] omas = Input(size);
            Output(omas);
           
            Console.ReadKey();
        }
    }
}
