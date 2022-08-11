// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int Number = new Random().Next(100, 1000);
Console.WriteLine(Number);

int a = Number / 100;
int b = Number % 10;
int Num = a * 10 + b;

Console.WriteLine($"Искомое число = {Num}");