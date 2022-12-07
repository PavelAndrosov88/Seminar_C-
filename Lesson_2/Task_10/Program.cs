Console.Clear();

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n = number / 10 % 10;

Console.WriteLine($"Вторая цифра у числа {number}: {n}");