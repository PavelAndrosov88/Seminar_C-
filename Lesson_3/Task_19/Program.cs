Console.Clear();

Console.Write("Введите пятизначное число: ");
string? s = Console.ReadLine();

if(s?[0] == s?[4] && s?[1] == s?[3])
    Console.WriteLine("ДА");
else 
    Console.WriteLine("НЕТ");
