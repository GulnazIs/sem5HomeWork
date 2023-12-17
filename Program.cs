//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] array = new int[11,13]; 

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
        array[i,j] = new Random().Next(1,10);
        Console.Write(array[i,j]+ " ");
       }
       Console.WriteLine();
    }
}

void FindEl()
{
   Console.WriteLine("Введите номер строки и столбца");
   int a = Convert.ToInt32(Console.ReadLine()); 
   int b = Convert.ToInt32(Console.ReadLine());
   
   if (a < array.GetLength(0) && b < array.GetLength(1))
   {
    Console.WriteLine("Искомый элемент: "+ array[a,b]);    
   }
   else
   {
    Console.WriteLine("Такого элемента в массиве нет."); 
   }
} 

CreateArray();
FindEl();
