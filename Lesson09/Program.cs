using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson09
{
    class Program
    {
        private static int screenWidth = 119;
        private static String divider = new String('=', screenWidth);

        private static void Divider( int _size )
        {
            String _divider = new String('=', _size);
            Console.WriteLine(_divider);
        }

        static void PrintNaturalNumber( int _n )
        {
            Console.Write("{0}, ", _n);
            if (_n > 1) PrintNaturalNumber(_n - 1);
        }

        static void PrintSequence( int _N )
        {
            Console.Write(" N = {0} -> ", _N);
            PrintNaturalNumber(_n: _N);
            Console.WriteLine();
        }
        
        static void Main( string[] args )
        {
            //Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
            //    N = 5 -> "5, 4, 3, 2, 1"
            //    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
            Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
            Console.Write("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            PrintSequence(N);
            PrintSequence(5);
            PrintSequence(8);
            Divider(screenWidth);
            //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            //    M = 1; N = 15 -> 120
            //    M = 4; N = 8. -> 30
            Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");

            Divider(screenWidth);
            //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            //    m = 2, n = 3 -> A(m,n) = 9
            //    m = 3, n = 2 -> A(m,n) = 29
            Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");

            Console.ReadKey();
        }
    }
}
