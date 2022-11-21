// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите целое число ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 0)
{
        Console.WriteLine($"Число {num1} является четный");
}
else
{
    Console.WriteLine($"Число {num1} является не четный");
}