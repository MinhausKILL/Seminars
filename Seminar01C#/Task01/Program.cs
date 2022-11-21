Console.WriteLine("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num*num;
//Console.WriteLine("Квадрат введеного числа равен "+square);
Console.WriteLine($"Квадрат введеного числа равен {square}");

if (num>9 && num<100) // проверка на 2-хзначное число и выше
{
    Console.WriteLine("Вы ввели двухзначное число!");
}

while(num<=25) // вывод всех числе от введеного до 25
{
    Console.Write($"{num} ");
    num++;
}
Console.WriteLine();