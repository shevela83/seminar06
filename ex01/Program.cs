// **Задача 39:** Напишите программу,
//  которая перевернёт одномерный массив 
//  (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

Console.Clear();
int size = 10;
int[] array = GetArray(size);



Console.WriteLine($"[{String.Join(", ", array)}] ");
reverse(array);
Console.WriteLine($"[{String.Join(", ", array)}] ");







int[] GetArray(int size) //задаем заполняемость массива от 100 до 999
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(0, 10);
  }
  return array;
}

void reverse (int [] array)
{
    
    int half = (array.Length/2);
    int left = 0;
    for (int i = 0; i<half; i++ )
    {
        left = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = left;
    }
}