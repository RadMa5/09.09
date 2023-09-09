
void Counter(int max)
{
    if (max > 0)
    {
        Console.Write($"{max}, ");
        max--;
        Counter(max);
    }
}
Console.Write("Input a number: ");
Counter(Console.ReadLine());