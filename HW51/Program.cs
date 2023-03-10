// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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
int GetQtyEvenNumbers(int[] array)
{
    int Qty = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Qty++;
        }
    }
    return Qty;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 999);
        index++;
    }
}

int length = GetIncomingData("Введите длину массива");
int[] arr = CreateArray(length);
FillArray(arr);
Print(arr);
 Console.WriteLine(GetQtyEvenNumbers(arr));