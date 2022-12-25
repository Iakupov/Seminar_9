int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return 0;
}
Console.WriteLine("Введите число число m и n через пробел:");
int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine(Akkerman(data[0], data[1]));
