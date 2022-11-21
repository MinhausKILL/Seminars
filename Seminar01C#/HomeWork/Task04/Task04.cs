//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 1-ое целое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое целое число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е целое число ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
        Console.WriteLine($"Max={num1}");
}
else if (num1 < num2 && num2 > num3)
{
    Console.WriteLine($"Max={num2}");
}
else
{
    Console.WriteLine($"Max={num3}");
}
