﻿// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Ход выполнения:
// 1. на вход принимает число
// 2. выдёт его квадрат
// 3. вывод результата

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;
Console.WriteLine(number + " -> " + square);
//Console.WriteLine($"{number} -> {square}");  --интерполяция, типа удобнее
