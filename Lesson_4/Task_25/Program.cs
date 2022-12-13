Console.Clear();

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int res = 1;
if (B == 0)
    Console.WriteLine($"А в степени B = 1");
else 
{
    for(int i = 1; i <= B; i++ )
        res = res * A; 
 Console.WriteLine($"А в сепени B = {res}");
 } 
