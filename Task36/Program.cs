/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/
Console.WriteLine("Укаждите число элементов массива: ");
int n = int.Parse(Console.ReadLine());

int[] GetArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(0, 100000);
    }
    return array;
}

//for(int i)

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


void PrintArrays(int[] array)
{
    int sum = 0; 
    for(int i = 0; i < array.Length; i +=2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях  = {sum}"); 
}    

PrintArrays(array);   