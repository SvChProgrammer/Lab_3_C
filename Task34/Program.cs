/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных */

Console.WriteLine("Укаждите число элементов массива: ");
int n = int.Parse(Console.ReadLine());

int[] GetArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int[] array = GetArray(n);

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i <array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

PrintArray(array);

int GetPositivElArray()
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    
    if (array[i] % 2 == 0)
    {
        count++;

    }
       Console.WriteLine($"всего {array.Length} чисел, {count} из них чётные");     
    return count;
}

GetPositivElArray();
