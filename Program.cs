// // Условия задачи №1
// // Задайте массив. Напишите программу, которая определяет,
// // присутствует ли заданное число в массиве. Программа
// // должна выдать ответ: Да/Нет.

// using System.Buffers;

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// bool CheckNumInArray(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num) return true;
//     }
//     return false;
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, min, max);
// PrintArray(array);

// Console.WriteLine("Input element to find: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(CheckNumInArray(array, num));

// Условие задачи №2
// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] ReplacingSign(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
PrintArray(array);
PrintArray(ReplacingSign(array));