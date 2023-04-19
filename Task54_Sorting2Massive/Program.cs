// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int ReadInt(string arg)
{
    System.Console.Write($"Введите {arg}: ");
    return int.Parse(Console.ReadLine());
}

int [,] CreateArray (int length1, int length2)
{
    int [,] Array = new int [length1, length2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
           Array[i,j] = new Random().Next(1, 100);
        }
    }
    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
           Console.Write(Array[i,j]+" ");
           
        }
        Console.WriteLine();
    }
}

int length1 = ReadInt("количество строк");
int length2 = ReadInt("количество столбцов");
int [,] Array = CreateArray (length1, length2);

PrintArray(Array);

Console.WriteLine($"\nОтсортированный массив: ");
Numbers(Array);
PrintArray(Array);

void Numbers(int [,] Array)
{
   for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            {
                 for (int k = 0; k < Array.GetLength(1) - 1; k++)                                              
                {
                    if (Array[i, k] < Array[i, k + 1])
                    {
                        int temp = Array[i, k + 1];
                        Array[i, k + 1] = Array[i, k];
                        Array[i, k] = temp;
                    }
                }
            }
        }
    }
}


