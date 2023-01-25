//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

using static System.Console;
Clear();

Write("Введите число k1: ");
double.TryParse(ReadLine(), out double k1);
Write("Введите число b1: ");
double.TryParse(ReadLine(), out double b1);
Write("Введите число k2: ");
double.TryParse(ReadLine(), out double k2);
Write("Введите число b2: ");
double.TryParse(ReadLine(), out double b2);


var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;

WriteLine($"Пересечение в точке: ({x};{y})");

