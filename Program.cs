// задача 34 . задайте массив заполненный случайными положительными трехзначными числами .
// напишите программу, которая покажет количество чисел в массиве [345, 897, 234] -> 2

Console.Clear();
int[] array = GetArray();
PrintArray(array);
Console.Write($" -> {GetEvenNumbers(array)}");

int[] GetArray()
{
    int size = new Random().Next(5,15);
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(99, 999);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"[{String.Join(", ", array)}]");
}
int GetEvenNumbers(int[] array)
{
    int cout = 0;
    for (int i =0, i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            cout++;
        }
    }
    return cout;
}
