﻿Console.Clear();
Console.WriteLine("Введите число c десятичной дробью через , ");
double numberA = double.Parse (Console.ReadLine());
Console.WriteLine (numberA);
double numberB = numberA * numberA;
Console.Write($"Квадратный корень {numberA} = {numberB} ");
