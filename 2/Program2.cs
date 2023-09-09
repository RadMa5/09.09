void SuMBetween(int M, int N)
    {
    for (int i = M + 1; i <= N; i++)
    {
        M += i;
    }
    Console.WriteLine(M);
}
SuMBetween(1, 15);
SuMBetween(4, 8);