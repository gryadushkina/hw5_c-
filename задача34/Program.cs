/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Clear();
int[] array = GetRandomArray(12,100,999);
int a = GetEvenCount(array);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"количество четных чисел в массиве равно {a}");

int GetEvenCount(int[] array2) 
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0) count += 1;
    }
    return count;
}

int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue+1);
    }

    return result;
}

