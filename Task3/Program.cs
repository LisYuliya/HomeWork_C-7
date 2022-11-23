/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine()!);

int[,] array = GetArrayRandom(rows, columns);

PrintArray(array);
Console.Write("Среднее арифметическое каждого столбца: ");
AverageOfColumns(array);
Console.WriteLine();

void AverageOfColumns(int[,] array)
{
    double sum=0; 
    double average=0;
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+=array[j,i];
            average=Math.Round(sum/columns,2);
        }
    
        Console.Write(average+"; ");
        sum=0;
        average=0;
        
}
}

int[,] GetArrayRandom(int rows, int columns, int minValue = 0, int maxValue = 11)
{
    int[,] array = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();

    }
}

