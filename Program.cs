﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите номер дня недели (от 1 до 7): ");
        int day = int.Parse(Console.ReadLine());

        if (day < 1 || day > 7)
        {
            Console.WriteLine("Некорректный номер дня недели");
        }
        else if (day == 6 || day == 7)
        {
            Console.WriteLine("Это выходной день");
        }
        else
        {
            Console.WriteLine("Это рабочий день");
        }
    }
}
