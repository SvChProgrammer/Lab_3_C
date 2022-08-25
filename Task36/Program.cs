/*������ 36: ������� ���������� ������, ����������� ���������� �������. ������� ����� ���������, ������� �� �������� ��������.*/
Console.WriteLine("������� ����� ��������� �������: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("������� ����������� ������� �������: ");
int min = int.Parse(Console.ReadLine());

Console.WriteLine("������� ������������ ������� �������: ");
int max = int.Parse(Console.ReadLine());


int[] GetArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(min, max);
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

void PrintArrays(int[] array)
{
    int sum = 0; 
    for(int i = 0; i < array.Length; i +=2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine($"����� ��������� �������, ������� �� �������� ��������  = {sum}"); 
}    

PrintArrays(array);   