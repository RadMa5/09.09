
void Counter(int max)
{
    if (max > 1)
    {
        Console.Write($"{max}, ");
        max--;
        Counter(max);
    }
    else { Console.Write(1); }
}
Console.Write("Input a number: ");
Counter(int.Parse(Console.ReadLine()));