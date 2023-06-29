﻿/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/ 

Console.Clear();
int[] array = GetRandomArray(10, 0, 10);
int sum = SumOddNum(array);
Console.WriteLine($"[{String.Join(", ", array)}] -> {sum}");






int SumOddNum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum += arr[i];
    }
    return sum;
}


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

