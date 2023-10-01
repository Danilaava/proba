﻿//Напишите программу, которая принимает на вход трёхзначное число, и на выходе показывает последнюю цифру этого числа
//4 5 6 -> 6
//7 8 2 -> 2
//9 1 8 -> 8

Console.WriteLine("Введите трёхзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <0 ) number *= -1;
if (number >= 100 && number <= 999)
{
    int lastDigit = number % 10;
    Console.WriteLine($"Последняя цифра числа: {lastDigit}");
}
else Console.WriteLine("Некорректный ввод");