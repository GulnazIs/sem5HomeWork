//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void ChangeArray()
{
   int temp;
   for (int i = 0; i < array.GetLength(0); i++)
   {
      if (i == 0)
      {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            temp = array[i,j];
            array[i,j] = array[array.GetLength(0)-1,j];
            array[array.GetLength(0)-1,j] = temp;
         }

      }
   }   
}

CreateArray();
PrintArray();
ChangeArray();
PrintArray();