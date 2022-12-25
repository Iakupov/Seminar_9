int NumbersSum(int m, int n)
{
    if (m == n) return m;
    return m + NumbersSum(m + 1, n);
}
Console.WriteLine("Введите число число m и n через пробел:");
int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine(NumbersSum(data[0], data[1]));
