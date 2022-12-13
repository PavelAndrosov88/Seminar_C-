Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), Sum = 0; 

while(n > 0)
{
    Sum = Sum + (n % 10);
    n = n / 10;
}
Console.WriteLine($"Сумма цифр в числе: {Sum}");