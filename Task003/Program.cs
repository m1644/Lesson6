﻿// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.WriteLine("Введите число: ");
int num10 = Convert.ToInt32(Console.ReadLine());

int a = 0; // a - остаток после % деления из которого формируется число в двоичной системе исчисления
int i = 0;
 
int[] b = new int[10]; // массив с помощью которого двоичное число позже будет выведено с конца
 
while (num10 >= 1)
{
    a = num10 % 2;
    b[i] = a; i++;
    num10 = num10 / 2;
    Console.Write(a);
}