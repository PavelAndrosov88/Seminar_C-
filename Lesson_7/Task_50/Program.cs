void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
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
Console.Write("Введите координату a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > size[0] || b > size[1] || a <= 0 || b <= 0)
    Console.WriteLine("Такого элемента нет");
else
{
    int result = matrix[a - 1, b - 1];
    Console.Write($"Значение элемента: {result}");
}
