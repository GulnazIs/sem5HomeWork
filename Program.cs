//Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Задайте размер массива: количество строк и столбцов:");
int rows = Convert.ToInt32(Console.ReadLine());
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] array = new int [rows,cols];

void CreateArray()
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array [i,j] = new Random().Next(1,101);
      }
   }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i,j]+ " ");
      }
      Console.WriteLine();      
   }
   Console.WriteLine();  
}

void FindMinSumRow()
{
   int minSum = 0;
   int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
   {
      int sum = 0;
      for (int j = 0; j < array.GetLength(1); j++)
      {
         sum += array[i,j];
      }
      if (i == 0)
      {
         minSum = sum;
      }
      else if(sum < minSum)
      {
         minRow = i;      
      }
   }
   Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow+1}");   
}

CreateArray();
PrintArray();
FindMinSumRow();

