// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

const int Size = 12;
int[] numbers = new int[Size];
for (int i = 0; i < Size; i++)
{
    numbers[i] = new Random ().Next (-9, 10); //правая граница не включается
}

// for (int i = 0; i < Size; i++) // посетить все числа которые хранятся в массиве
// {
//    Console.WriteLine (numbers[i]);
// }
 
 int positivesSum = 0;
 int negativesSum = 0;

// для каждого числа numbers из массива чисел numbers
foreach (int number in numbers)
{
    if (number > 0)
        positivesSum += number;
    else if (number < 0)
        negativesSum += number;
}

Console.WriteLine($"Сумма положительных = {positivesSum}, сумма отрицательных = {negativesSum}");