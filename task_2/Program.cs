void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] CreateRandomArray(int N)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(100, 1000);
    }
    return RandomArray;
}

void SumOfOddNums(int[] sum)
{
    int sum1 = 0;
    for (int i = 0; i < sum.Length; i = i + 2)
    {
        sum1 = sum1 + sum[i];
    }
    Console.WriteLine($"Сумма чисел стоящих на нечетных позициях равна {sum1}");
}

Console.WriteLine("Сколько чисел будем считать?");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(a);
Console.WriteLine("Вот ваш массив: ");
ShowArray(array);
SumOfOddNums(array);