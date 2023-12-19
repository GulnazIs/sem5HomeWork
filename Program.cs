//Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
//Под удалением понимается создание нового двумерного массива без строки и столбца.

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
         array [i,j] = new Random().Next(1,100);
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

int iMin = 0;
int jMin = 0;

void FindMin()
{
   int min = array[0,0];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (array[i,j] < min)
         {
            min = array[i,j];
            iMin = i;
            jMin = j;
         }
      }    
   }
   Console.WriteLine(min);
   Console.WriteLine();
}

int [,] res = new int [array.GetLength(0), array.GetLength(1)];
int currentRow = 0;
int currentCol = 0;

void NewArray()
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      if (i != iMin)
      {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            if (j != jMin)
            {
               res[currentRow,currentCol] = array[i,j];
               Console.Write(res[currentRow,currentCol]+" ");
               currentCol++;
            }
         }
         currentRow++;
         currentCol = 0;
         Console.WriteLine();
      } 
   }
}

CreateArray();
PrintArray();
FindMin();
NewArray();
