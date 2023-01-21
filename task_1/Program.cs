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

void FindEvenSum(int[] sum)
{
    int count = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i]%2 == 0) count++;
    }
    Console.WriteLine($"В вашем массиве {count} чётных чисел.");
}


Console.WriteLine("Сколько чисел генерируем?");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(a);

ShowArray(array);
FindEvenSum(array);