// See https://aka.ms/new-console-template for more information
/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/

Console.WriteLine("**Задача 25**");
int Method25(int x, int y)
{
    int result = 1;

    for(int i = 0; i < y; i++)
    {
        result *= x;
    }
    return result;
} 

Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int y = int.Parse(Console.ReadLine());

int res = Method25(x, y);
Console.WriteLine("Результат: ");
Console.WriteLine("{0} ^ {1} = {2}", x, y, res);    


/*Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.*/
Console.WriteLine("**Задача 27**");
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int Method27(int number)
{
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    while(number != 0)
    {
        advance = number % 10;
        number = number /10;
        result = result + advance;
    }
    return result;
}

int sumNumber = Method27(number);
Console.WriteLine("Сумма цифр в числе равна: " + sumNumber);

/*Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран.*/

Console.WriteLine("**Задача 29**");
void  RanArray(){
    
    Console.WriteLine("Укаждите число элементов массива: ");
    int n = int.Parse(Console.ReadLine());

    int[] arr = new int[n];

    Console.WriteLine("Укажите начальное значение элементов массива: ");
    int begValue= int.Parse(Console.ReadLine());

    Console.WriteLine("Укажите конечное значение элементов массива: ");
    int endValue= int.Parse(Console.ReadLine());

    
    for(int i=0; i<arr.Length; i++){
        arr[i] = new Random().Next(begValue,endValue-1);
    }
    
Console.WriteLine("Сгенерированный массив: ");
Console.WriteLine($"[{String.Join(",", arr)}]"); 
}

 RanArray();



