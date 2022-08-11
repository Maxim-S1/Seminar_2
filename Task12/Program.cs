// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

int Remains = Number1 % Number2;

if (Remains == 0)
{
    Console.WriteLine($"Число {Number1} кратно числу {Number2}");
}
else
{
    Console.WriteLine($"Число {Number1} не кратно  числу {Number2}. Остаток {Remains}");
}