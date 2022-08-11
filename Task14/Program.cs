// Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

if (Number1 % 23 == 0 & Number1 % 7 == 0)
{
    Console.WriteLine($"Число {Number1} кратно числу 23 и 7.");
}
else
{
    Console.WriteLine($"Число {Number1} не кратно числу 23 и 7.");
}

