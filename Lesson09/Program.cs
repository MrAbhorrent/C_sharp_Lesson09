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

        private static void PrintNaturalNumber( int _n )
        {
            Console.Write("{0}, ", _n);
            if (_n > 1) PrintNaturalNumber(_n - 1);
        }

        private static void PrintSequence( int _N )
        {
            Console.Write(" N = {0} -> ", _N);
            PrintNaturalNumber(_n: _N);
            Console.WriteLine();
        }
        
        private static int RecursiveSum(int minValue, int maxValue)
        {            
            if (minValue > maxValue)
            {
                return 0;
            }
            return RecursiveSum(minValue + 1, maxValue) + minValue;
        }

        private static long AkkermanFunction( long n, long m )
        {
            if (n == 0)
            {
                return m + 1;
            }
            else if (n != 0 && m == 0)
            {
                return AkkermanFunction(n - 1, 1);
            }
            else if (n > 0 && m > 0)
            {
                return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
            }
            else
            {
                return AkkermanFunction(n, m);
            }
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
            Console.Write("Введите M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (m < n)
            {
                Console.WriteLine("M = {0}; N = {1} -> {2}", m, n, RecursiveSum(minValue: m, maxValue: n));
            }
            else
            {
                Console.WriteLine("M = {0}; N = {1} -> {2}", n, m, RecursiveSum(minValue: n, maxValue: m));
            }
            Console.WriteLine();
            Divider(screenWidth);
            //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            //    m = 2, n = 3 -> A(m,n) = 9
            //    m = 3, n = 2 -> A(m,n) = 29
            Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
            Console.Write("Введите m: ");
            int mValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите n: ");
            int nValie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("m = {0}; n = {1} -> A(m, n) = {2}", mValue, nValie, AkkermanFunction(mValue, nValie));
            Console.WriteLine("--- test mode ---");
            mValue = 2; nValie = 3;
            Console.WriteLine("m = {0}; n = {1} -> A(m, n) = {2}", mValue, nValie, AkkermanFunction(mValue, nValie));
            mValue = 3; nValie = 2;
            Console.WriteLine("m = {0}; n = {1} -> A(m, n) = {2}", mValue, nValie, AkkermanFunction(mValue, nValie));
            Console.ReadKey();
        }
    }
}
