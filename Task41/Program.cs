Console.Write($"Введите количество чисел: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] massiveNumbers = new int[count];

void InputNumbers(int count){
for (int i = 0; i < count; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int CountPositivElement(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(count);

Console.WriteLine($"Количество чисел больше 0: {CountPositivElement(massiveNumbers)} ");
