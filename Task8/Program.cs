// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();

Console.Write("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine());

int count = 2;

if (number > 1)
{
    while (count < (number / 2)*2 + 1)
    {
        Console.Write($"{count}, ");
        count = count + 2;
    }
}
else
{
    Console.Write("Нет данных, удовлетворящих условию задачи");
}

