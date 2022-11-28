/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число: ");
int number = new int();
number = Convert.ToInt32(Console.ReadLine());
number = number % 100;
int result = number / 10;
Console.WriteLine(result);