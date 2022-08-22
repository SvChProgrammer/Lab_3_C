Console.WriteLine("Укажите число элементов массива: ");
int n = int.Parse(Console.ReadLine());

double[] GetArray(int size)
{
    double[] array = new double[size];

    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(100, 1001);
    }
    return array;
}

double[] array = GetArray(n);

void PrintArray(double[] array)
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


double diffElArray(double[] array)
{
    double diff = 0;
    double min =  array[0];
    double max =  array[0];
   
   for (int i = 0; i < array.Length; i++){
       
        if(array[i] > max){
             max = array[i];
        }

        if(array[i] < min){
             min = array[i];
        }
}
Console.WriteLine($"Максимальный элемент массива: {max} ");
Console.WriteLine($"Минимальный элемент массива: {min} ");    

      diff = max - min;
      Console.WriteLine($" Разница между максимальным  и минимальным элементом массива:  {max} - {min}  =  {diff} ");    
      return diff;
}

diffElArray(array);