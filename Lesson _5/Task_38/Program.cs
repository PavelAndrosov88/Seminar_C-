void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().NextDouble() * (100 - 10) + 10;
}

void ReleaseArray(double[] array)
{
    double Max = 0, Min = 101;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max)
        Max = array[i]; 
        if (array[i] < Min)
        Min = array[i]; 
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом {Math.Round(Max - Min, 2)}");
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(". ", array)}]");
ReleaseArray(array);
