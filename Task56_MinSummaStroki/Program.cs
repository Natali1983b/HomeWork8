// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] CreateArray (int length1, int lenght2)
{
    int [,] Array = new int [length1, lenght2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
           Array[i,j] = new Random().Next(1, 9);
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

void SummOfTheNumbers(int[,] Array)
{
   int min = int.MaxValue;
   int index = 0;
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                int Sum = 0;
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Sum += Array[i, j];
                }
                if (Sum < min)
                {
                    min = Sum;
                    index = i + 1;
                }
            }
            Console.WriteLine($"минимальная сумма элементов = {min} находится в {index} строке");
            Console.WriteLine();
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                Console.Write(Array[index, i]+" ");
            }
}           

int [,] Array = CreateArray(5,4);
PrintArray(Array);
Console.WriteLine();
SummOfTheNumbers(Array);
