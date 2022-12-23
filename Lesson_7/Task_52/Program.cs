void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Cреднее арифметическое:");
for (int i = 0; i < size[1]; i++)
{
    double srAr = 0;
    for (int j = 0; j < size[0]; j++)
    {
        srAr += matrix[j, i];
    }
    srAr = Math.Round(srAr / size[0], 1);
    Console.WriteLine($"столбца № {i + 1}: {srAr}");
}