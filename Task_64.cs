string NaturalNumbers(int n,int z)
{
    string text="";
    if (z==n) return $"{z}";
    return text+=$"{NaturalNumbers(n,z+1)}, {z}";
}
Console.WriteLine("Введите число число n:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(NaturalNumbers(5,1));
