//$"Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов."
Console.WriteLine($"\nВведите размер массива m x n :");
//int m = InputNumbers("Введите m: ");
//int n = InputNumbers("Введите n: ");

Console.WriteLine("Введите количество строк");
int lineCnt = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int colCnt = int.Parse(Console.ReadLine());

//Console.WriteLine("Введите максимальное значение элемента столбцов");
int maxValue = InputNumbers("Введите максимальное значение элемента ");

int minValue = InputNumbers("Введите минимальное значение элемента ");

int[,] array = new int[lineCnt, colCnt];
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      //array[i, j] = new Random().Next(range);
      array[i, j] = Convert.ToInt32(new Random().Next(minValue, maxValue)) ;
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}