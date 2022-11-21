//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите целое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
int i = 1;


while(i <= num1) // вывод всех чисел от 1 введеного до Num1
{
    if (i % 2 != 1)
    {
        Console.Write( i + ", " );
    }
    i++;
}
