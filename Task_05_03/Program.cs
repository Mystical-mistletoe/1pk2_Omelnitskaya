using System;

namespace Task_05_03
{
    internal class Program
    {
        /*
         * Даны два массива, заполненные символами английского 
         * алфавита размером 3*3. Проверить, являются ли 
         * матрицы равными, если да, то вывести сообщение 
         * о том, что они равны, если нет, то вывести повторно 
         * матрицы с цветовой индикацией только тех элементов, 
         * которые равны. (матрицы считаются равными, если их 
         * соответствующие элементы равны.
         * Пример:
         * f h h f c h
         * w g k m g z
         * a f j a o d
         * =>
         * f h h f c h
         * w g k m g z
         * a f j a o d 
         */
        static void Main(string[] args)
        {

            char[,] charsOne = 
            {
                {'f', 'h', 'h' },
                {'w', 'g', 'k' },
                {'a', 'f', 'j' }
            };
            char[,] charsTwo =
            {
                {'f', 'c', 'h' },
                {'m', 'g', 'z' },
                {'a', 'o', 'd' }
            };

            for (int i = 0; i < charsOne.GetLength(0); i++)
            {
                for (int j = 0; j < charsOne.GetLength(1); j++)
                {
                    Console.Write(charsOne[i, j] + " ");
                }

                Console.Write("\t");

                for (int j = 0; j < charsOne.GetLength(1); j++)
                {
                    Console.Write(charsTwo[i, j] + " ");
                }

                Console.WriteLine();
            }

            int n = 3;
            /* Код с подстановкой рандомных значений
             * 
            char[,] charsOne = new char[n, n];
            char[,] charsTwo = new char[n, n];
            Random random = new Random();

            for (int i = 0; i < charsOne.GetLength(0); i++)
            {
                for (int j = 0; j < charsOne.GetLength(1); j++)
                {
                    charsOne[i, j] = (char)random.Next(97, 123);
                    Console.Write(charsOne[i, j] + " ");
                }

                Console.Write("\t");

                for (int j = 0; j < charsOne.GetLength(1); j++)
                {
                    charsTwo[i, j] = (char)random.Next(97, 123);
                    Console.Write(charsTwo[i, j] + " ");
                }

                Console.WriteLine();
            }
            */

            Console.WriteLine("=>");
            bool flag = false;

            for (int i = 0; i < charsOne.GetLength(0); i++)
            {
                for (int j = 0; j < charsOne.GetLength(1); j++)
                {
                    if (charsOne[i, j] != charsTwo[i, j])
                    {
                        flag = true;
                        break;
                    }
                }
            }
            if (flag)
            {
                for (int i = 0; i < charsOne.GetLength(0); i++)
                {
                    for (int j = 0; j < charsOne.GetLength(1); j++)
                    {
                        if (charsOne[i, j] == charsTwo[i, j])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        Console.Write(charsOne[i, j] + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.Write("\t");

                    for (int j = 0; j < charsOne.GetLength(1); j++)
                    {
                        if (charsOne[i, j] == charsTwo[i, j])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        Console.Write(charsTwo[i, j] + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("матрицы равны");
            }


        }
    }
}
