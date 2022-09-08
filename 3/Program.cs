Console.Write("Input number M: ");
int numN = int.Parse(Console.ReadLine());
Console.Write("Input number N: ");
int numM = int.Parse(Console.ReadLine());
int akk = result(numM, numN);
int result(int numM, int numN)
{
    if (numM == 0)
        return numN + 1;
    else if ((numM != 0) && (numN == 0))
        return result(numM - 1, 1);
    else
        return result(numM - 1, result(numM, numN - 1));
}
Console.WriteLine(akk);