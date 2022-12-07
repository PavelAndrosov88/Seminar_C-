
Console.Clear();
Console.Write("Введите 1-oe число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-oe число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine($"max = {a} min = {b}");
else
    Console.WriteLine($"max = {b} min = {a}");
