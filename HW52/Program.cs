//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int GetIncomingData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int length)
{
    return new int[length];
}

void Print(int[] array)
{
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        if (index == size - 1)
        {
            Console.Write(array[index]);
        }
        else
        {
            Console.Write($"{array[index]},");
        }
        ++index;
    }
    Console.WriteLine();

}
int GetSumm(int[] array)
{
    int Summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            Summ = Summ + array[i];
        }
    }
    return Summ;
}

void FillArray(int[] collection, int low, int high)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(low, high);
        index++;
    }
}

int length = GetIncomingData("Введите длину массива");
int[] arr = CreateArray(length);
int low = GetIncomingData("Введите нижнюю границу значений элементов массива");
int high = GetIncomingData("Введите верхнюю границу значений элементов массива");
FillArray(arr, low ,high);
Print(arr);
 Console.WriteLine(GetSumm(arr));
