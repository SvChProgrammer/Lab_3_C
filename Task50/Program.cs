Console.WriteLine("Введите количество строк");
int lineCnt = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int colCnt = int.Parse(Console.ReadLine());

double[,] numbers = new double[lineCnt, colCnt];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

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


Console.WriteLine("Укажите строку: ");
int lineCntArray = int.Parse(Console.ReadLine());

Console.WriteLine("Укажите столбец: ");
int colCntArray = int.Parse(Console.ReadLine());


if (lineCntArray > numbers.GetLength(0) || colCntArray > numbers.GetLength(1))
{
    Console.WriteLine("Tакой элемент не существует");
}
else
{
    Console.WriteLine($"значение элемента {lineCntArray} строки и {colCntArray} столбца равно {numbers[lineCntArray,colCntArray]}");
}
