Console.Clear();

Console.Write("Введите цифру от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n == 6 || n == 7)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");
