Console.Clear();

Console.Write ("Введите числа через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int sum = 0;

foreach (int element in size)
    if (element > 0)
    sum ++;
Console.WriteLine($"Колличетво чисел больше 0 = {sum} ");