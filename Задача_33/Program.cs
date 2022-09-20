// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

const int Size = 15;
int[] array = CreateArray(Size);
Console.WriteLine("Введите число ");
int search = int.Parse(Console.ReadLine());
PrintArray(array);

if (LookForExact((array), search))
{
    Console.WriteLine($"В данном массиве искомое число {search} присутствует");
}
else
{
   Console.WriteLine($"В данном массиве искомое число {search} отсутствует"); 
}

int[] CreateArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 100);
    }
    return numbers;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write ($"{arr[i]} ");
    }
    Console.WriteLine();
}

bool LookForExact(int[] arr, int exact)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == exact)
            return true;
    }
    return false;
}