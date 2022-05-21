int PowSum(int a, int b)
{
    int sum = 1;
    for (int i = 0; i < b; i++)
    {
        sum = sum * a;
    }
    return sum;
}

Console.WriteLine(PowSum(3,5));