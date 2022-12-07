Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n = number;
if (n < 100)
    Console.WriteLine($"Третьей цифры у числа {number} нет");
else 
{
    while (n > 999) n = n / 10;
    n = n % 10;
    Console.WriteLine($"Третья цифра у числа {number}: {n}");
}
