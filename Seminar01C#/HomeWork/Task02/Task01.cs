Console.WriteLine("Введите 1-ое целое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое целое число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
        Console.WriteLine($"Max={num1} Min={num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"Max={num2} Min={num1}");
}
else
{
    Console.WriteLine($"Max & Min = {num1}");
}
