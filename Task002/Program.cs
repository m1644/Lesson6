// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int C = Convert.ToInt32(Console.ReadLine());
if ((A < B + C) && (B < A + C) && (C < A + B))
{
    Console.WriteLine("Такой треугольник существует");
}
else Console.WriteLine("Такого треугольника НЕ существует");
