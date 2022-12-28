void PrintNumber(int n, int m)
{
  if (m > n) return;
  PrintNumber(n, m + 1);
  Console.Write(m + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Console.Clear();
int n = InputNumbers("Введите n: ");
int m = InputNumbers("Введите m: ");
PrintNumber(n, m);
