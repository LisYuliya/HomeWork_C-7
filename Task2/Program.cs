/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine()!);

int[,] array = GetArrayRandom(rows, columns);

PrintArray(array);
SearchItem(array);


void SearchItem(int[,]array)
{
Console.WriteLine("Введите номер элемента в строке");
int RowCoordinates = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер элемента в столбце");
int ColumnCoordinates = Convert.ToInt32(Console.ReadLine()!);
if (RowCoordinates >= rows+1 || ColumnCoordinates >= columns+1) //Добавлены единицы, чтобы при вводе номера числа счет начинался с 1, а не с 0
{
    Console.WriteLine("Такого элемета в массиве нет");
}
else if(RowCoordinates <= 0 || ColumnCoordinates <= 0 )
{
    Console.WriteLine("Нумерация элементов в массиве начинается с 1");
     SearchItem(array);
}
else
{
    Console.WriteLine($"Элемент в массиве, с заданными координатами равен {array[RowCoordinates-1,ColumnCoordinates-1]}");  //чтобы при вводе номера числа счет начинался с 1, а не с 0
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
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();

    }
}

