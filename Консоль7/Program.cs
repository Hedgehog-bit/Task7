﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль7
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите строку: ");
            StringBuilder a = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Исходная строка: " + a);
            char x = '(';
            char y = ')';
            int Markx = 0;
            int Marky = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] == x) Markx = i;
                if (a[i] == y) Marky = i;
            }
            int j = 0;
            string[] a2 = new string[a.Length - (Marky - Markx + 1)];
            for (int i = 0; i < a.Length; i++)
            {
                if ((i < Markx) || (i > Marky))
                {
                    while (j < a2.Length)
                    {
                        a2[j] = a[i].ToString();
                        j++;
                        break;
                    }
                }
            }
            string a3 = "";
            for (int i = 0; i < a2.Length; i++)
            {
                a3 += a2[i];
            }
            Console.WriteLine("Изменёная строка: " + a3);

            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            input = input.ToLower();
            string[] str = input.Split(' ');
            int marker = 0;
            Console.Write("Кол-во встречающих раз в тексте: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                for (j = 0; j < str.Length; j++)
                {
                    if ((str[i] == str[j]) && (str[j] != "")) 
                    {
                        marker++;
                    }
                }
                if (marker >= n)
                {
                    Console.WriteLine("Слово " + str[i] + " Встречалось " + marker + " раза");
                }
                marker = 0;
                for (j = 0; j < str.Length; j++)
                {
                    if ((str[i] == str[j]) && (i != j))
                    {
                        str[j] = "";
                    }
                }
                str[i] = "";
            }


            Console.ReadKey();
        }
    }
}
