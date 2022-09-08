Console.Write("Input number M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Input number N: ");
int numN = int.Parse(Console.ReadLine());

int result = allNum(numM, numN);
Console.WriteLine(result);

int allNum(int start, int end)
{
    return start == end ? end : allNum(start + 1, end) + start;
}