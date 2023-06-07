/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

Console.Clear();
double[] array = GetRandomArray(12,100,999);
double a = MaxMinNumber(array);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"разница между максимальным и минимальным элементов массива равна  {a}");

double[] GetRandomArray(int size,int minValue,int maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue+1);
    }

    return result;
}

double MaxMinNumber(double[] array2)
{
    double max = array2[0];
    double min = array2[1];
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i] > max)
        {
            max = array[i];
        }
        else if (array2[i] < min)
        {    
            min = array[i];
        }
    }
    
    double rez = max - min; 
    return rez;
    
}