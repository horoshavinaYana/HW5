// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int GetIncomingData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

float[] CreateArray(int length)
{
    return new float[length];
}

void Print(float[] array)
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
            Console.Write($"{array[index]}; ");
        }
        ++index;
    }
    Console.WriteLine();

}

float GetMinValue(float[] array)
{
    float Min = float.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (Min >= array[i])
        {
            Min = array[i];
        }
    }
    return Min;
}

float GetMaxValue(float[] array)
{
    float Max = float.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (Max <= array[i])
        {
            Max = array[i];
        }
    }
    return Max;
}

float GetDiffMinMaxValue(float[] array)
{
    return GetMaxValue(array) - GetMinValue(array);
}

void FillArray(float[] collection, int low, int high)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = (new Random().NextSingle() * (high - low) + low);
        index++;
    }
}

int length = GetIncomingData("Введите длину массива");
float[] arr = CreateArray(length);
int low = GetIncomingData("Введите нижнюю границу значений элементов массива");
int high = GetIncomingData("Введите верхнюю границу значений элементов массива");
FillArray(arr, low, high);
Print(arr);
Console.WriteLine(GetDiffMinMaxValue(arr));