// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Write("Введите количество строк 1 массива: ");
int rowsA = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int columnsA = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк 2 массива: ");
int rowsB = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int columnsB = int.Parse(Console.ReadLine());
if (columnsA != rowsB)
{
  Console.WriteLine("Такие матрицы умножать нельзя!");
  return;
}
    int[,] matrix1 = GetArray(rowsA, columnsA, 0, 10);
    int[,] matrix2 = GetArray(rowsB, columnsB, 0, 10);
    PrintArray(matrix1);
    Console.WriteLine();
    PrintArray(matrix2);
    Console.WriteLine();
    PrintArray(Product(matrix1, matrix2));

    int[,] GetArray(int lenth1, int lenth2, int min, int max)
    {
      int[,] result = new int[lenth1, lenth2];
    for (int i = 0; i < lenth1; i++)
    {
      for (int j = 0; j < lenth2; j++)
      {
        result[i, j] = new Random().Next(min, max + 1);
      }
      
    }
      return result;
    }

    void PrintArray(int[,] array)
    {
     for (int i = 0; i < array.GetLength(0); i++)
     {
       for (int j = 0; j < array.GetLength(1); j++)
       {
         Console.Write($"{array[i, j]} ");
       }
       Console.WriteLine();
     }
    }


int [,] Product(int [,] matrix1, int [,] matrix2)
{
int[,] array = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
      for (int i = 0; i < matrix1.GetLength(0); i++)
      {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
          for (int k = 0; k < matrix1.GetLength(1); k++)
          {
            array[i, j] += matrix1[i, k] * matrix2[k, j];
          }
        }
      }
      return array;
}
