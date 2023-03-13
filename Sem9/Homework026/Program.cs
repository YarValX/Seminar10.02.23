Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int SumFor(int M, int N)
{
    int result = 0;
    for (int i = M; i <= N; i++) result += i;
    return result;
}
int SumRec(int M, int N)
{
    if (M > N) return 0;
    if (M == N) return N;
    else return M + SumRec(M + 1, N);
}
Console.WriteLine(SumFor(M, N));
Console.WriteLine(SumRec(M, N));