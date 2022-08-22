int[] BubbleSort(int[] array)
{
  Console.WriteLine ("Отсортированный массив");     
  for (int i = 0; i < array.Length; i++){
      
      for (int j = 0; j < array.Length - i - 1; j++)
      {
           if (array[j] > array[j+1])
           {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
           }
       }
    
    Console.Write(array[i] + " ");
  }               
    return array;       
}

Console.WriteLine("Укаждите число элементов массива: ");
int n = int.Parse(Console.ReadLine());

int[] GetArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i<size; i++) {

        array[i] = new Random().Next(0, 100000);
    }
    return array;
}

int[] array = GetArray(n);


void PrintArray(int[] array)
{
    Console.WriteLine("Созданный массив");
    Console.Write("[ ");
    for(int i = 0; i <array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

PrintArray(array);
BubbleSort(array);

