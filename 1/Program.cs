Console.Write("Input number M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Input number N: ");
int numN = int.Parse(Console.ReadLine());
Console.WriteLine(allNum(numM, numN));
int allNum(int start, int end){
    if(start == end) return start;
    Console.Write($"{start} ");
    return allNum(start + 1, end);
}