string[] FillArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите значения {i} индекса массива -> ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"‟{array[i]}‟,");
        else Console.Write($"‟{array[i]}‟");
    }
    Console.Write("]");
}
string[] FilterArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }

    string[] newArray = new string[count];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k++;
        }
    }
    return newArray;
}
Console.Write("Введите размер массива -> ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
if (sizeArray < 0) Console.WriteLine("Вы ввели некорректный размер массива");
else
{
    string[] array = FillArray(sizeArray);
    PrintArray(array);
    string[] arrayNew = FilterArray(array);
    Console.Write(" -> ");
    PrintArray(arrayNew);
}