void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}

int Difference(int[] array)
{
    int min = array[0];
    int max = array[0];
    foreach(var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max-min;
}

Console.WriteLine("Давайте посчитаем разницу минимального и максимального элемента в масcиве!");
Console.WriteLine("Укажите колличество элементов: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите в каком диапазоне генерируем элементы: ");
Console.WriteLine("От ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("До ");
int c = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray(a, b, c);
Console.WriteLine("Ваш массив: ");
ShowArray(array);
Console.WriteLine();
Console.WriteLine($"Разница минимального и максимального элемента равна: {Difference(array)}");