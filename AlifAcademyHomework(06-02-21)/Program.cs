using System;

namespace AlifAcademyHomework_06_02_21_
{

    static class ArrayHelper
    {
        //method pop
        public static T Pop<T> (ref T[] mas)
        {
            if (mas.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ваш массив пуст.");
                Console.ForegroundColor = ConsoleColor.White;
                return default;
            }

            T deleted = mas[mas.Length - 1];
            Array.Resize(ref mas, mas.Length - 1);
            return deleted;
        }

        //method push
        public static int Push <T>(ref T[] mas, T added)
        {
            Array.Resize(ref mas, mas.Length + 1);
            mas[mas.Length - 1] = added;
            return mas.Length;
        }

        //method shift
        public static T Shift <T>(ref T[] mas)
        {
            if (mas.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ваш массив пуст");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Array.Reverse(mas);
            T added = mas[mas.Length - 1];
            Array.Resize(ref mas, mas.Length - 1);
            Array.Reverse(mas);
            return added;
        }

        //method unshift
        public static int UnShift<T>(ref T[] mas, T added)
        {
            Array.Reverse(mas);
            Array.Resize(ref mas, mas.Length + 1);
            mas[mas.Length - 1] = added;
            Array.Reverse(mas);
            return mas.Length;
        }

        //method slice with begin and end
        public static T[] Slice<T>(ref T[] mas, int begin, int end)
        {
            if (begin > mas.Length)
            {
                T[] check = new T[0];
                Console.WriteLine("Массив пуст");
                return check;
            }
            if (begin < 0)
            {
                begin = mas.Length - Math.Abs(begin);
            }
            if (end < 0)
            {
                end = mas.Length - Math.Abs(end);
            }
            T[] mas2 = new T[end - begin];
            int j = 0;
            for (int i = begin; i < end; i++)
            {
                mas2[j] = mas[i];
                j++;
            }
            
            return mas2;
        }

        //method slice with begin
        public static T[] Slice<T>(ref T[] mas, int begin)
        {
            if (begin > mas.Length)
            {
                T[] check = new T[0];
                Console.WriteLine("Массив пуст");
                return check;
            }
            if (begin < 0)
            {
                begin = mas.Length - Math.Abs(begin);
            }

            T[] mas2 = new T[mas.Length - begin];
              
                int j = 0;
                for (int i = begin; i < mas.Length; i++)
                {
                    mas2[j] = mas[i];
                    j++;
                }            
            return mas2;
        }

        //method slice without begin and end
        public static T[] Slice<T>(ref T[] mas)
        {
            T[] mas2 = new T[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                mas2[i] = mas[i];
            }
            return mas2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = new string[] { "ant", "bison", "camel", "duck", "elephant" };            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Программа работает...");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadKey();
        }
    }
}
