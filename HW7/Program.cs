// HW7
// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

double[,] CreateRandom2dDoubleArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        {
            int numbersIntPart = new Random().Next(minValue, maxValue);
            double numbersDoublePart = new Random().NextDouble();
    
            array[i,j] = Math.Round(Convert.ToDouble(numbersIntPart) + numbersDoublePart, 2);
        }
            

    return array;
}

void Show2dDoubleArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] >= 0 && array[i,j] < 10)
                Console.Write("  " + array[i,j].ToString("0.00") + "   ");
            else if(array[i,j] >= 10 || array[i,j] < 0 && array[i,j] > -10)
                Console.Write(" " + array[i,j].ToString("0.00") + "   ");
            else
                Console.Write(array[i,j].ToString("0.00") + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*
Console.Write("Input a number of rows: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input an integer min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input an integer max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dDoubleArray(m, n, min, max);
Show2dDoubleArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dIntArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dIntArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] >= 0 && array[i,j] < 10)   
                Console.Write("  " + array[i,j] + "   ");
            else if(array[i,j] >= 10 || array[i,j] < 0 && array[i,j] > -10)
                Console.Write(" " + array[i,j] + "   ");
            else
                Console.Write(array[i,j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

bool IsThisNonexistentPosition(int i, int j, int[,] array)
{
    if(i >= array.GetLength(0) || j >= array.GetLength(1) || i < 0 || j < 0)
        return true;
    else return false;
} 
/*
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dIntArray(m, n, min, max);
Show2dIntArray(myArray);

Console.WriteLine("Input a position of element:");
Console.Write("row index (starting from zero): ");
int rowNum = Convert.ToInt32(Console.ReadLine());
Console.Write("column index (starting from zero): ");
int colNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(IsThisNonexistentPosition(rowNum, colNum, myArray)) 
    Console.WriteLine("There are no elements with such indices in the array");
else
    Console.WriteLine($"element with this indices is: {myArray[rowNum, colNum]}");
*/

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

double[] CreateAverageInColumnsArray(int[,] array)
{
    double[] averageArray = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
            sum += array[i,j]; 
        averageArray[j] = Math.Round(Convert.ToDouble(sum) / 
                                Convert.ToDouble(array.GetLength(0)), 2);
    }
return averageArray;
}

void ShowAverageInColumnsArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "   ");
    
    Console.WriteLine();
}
/*
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dIntArray(m, n, min, max);
Show2dIntArray(myArray);

double[] averageInColumnsArray = CreateAverageInColumnsArray(myArray);
ShowAverageInColumnsArray(averageInColumnsArray);
Console.WriteLine();
*/

