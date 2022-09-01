Console.WriteLine("Введите количество строк");
int lineCnt = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int colCnt = int.Parse(Console.ReadLine());

double[,] numbers = new double[lineCnt, colCnt];


void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) ;
        }
    }
}

FillArrayRandomNumbers(numbers);

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

PrintArray(numbers);

void SortArray(double[,] array)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < numbers.GetLength(1) - 1; z++)
            {
                if (numbers[i, z] < numbers[i, z + 1]) 
                {
                double temp = array[i, z + 1];
                array[i, z + 1] = array[i, z];
                array[i, z] = temp;
                }
            }
        }
    }
    PrintArray(array);
}

Console.WriteLine("Сортированный массив: ");
SortArray(numbers);