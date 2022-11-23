//HW8
// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
void GetSortedRowsArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int sortedSize = 0; sortedSize < array.GetLength(1) - 1; sortedSize++) // цикл полностью сортирует одну строку  
            for(int j = 0; j < array.GetLength(1) - 1 - sortedSize; j++) // цикл перемещает мин. эл-т в конец неотсортированной части массива
                if(array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }  
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

GetSortedRowsArray(myArray);
Console.WriteLine("Array with the elements of each row sorted in descending order:");
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Программа выдаёт номер строки

/*
int RowNumberMinElementsSum(int[,] array)
{
    int[] rowSum = new int[array.GetLength(0)];
   
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++) 
            rowSum[i] += array[i,j];

    int minRowSum = rowSum[0];
    int rowNum = 0;
    for(int i = 1; i < array.GetLength(0); i++) 
        if(rowSum[i] < minRowSum)
        {
            minRowSum = rowSum[i];
            rowNum = i + 1;
        }    
    
    return rowNum;
}


Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

Console.WriteLine($"Number of row with min sum of elements is: {RowNumberMinElementsSum(myArray)}"); 
Console.WriteLine("(row numbering starting from 1)");
Console.WriteLine();
*/

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
/*

int[,] Multiply2Arrays(int[,] arrayA, int[,] arrayB)
{
    int rows = arrayA.GetLength(0);
    int columns = arrayB.GetLength(1);
    int finalValueForSum = arrayA.GetLength(1); // оно же arrayB.GetLength(0)

    int[,] multArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            for(int k = 0; k < finalValueForSum; k++)
                multArray[i,j] += arrayA[i,k] * arrayB[k,j];

    return multArray;
}

Console.Write("Input a number of rows of array A: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns of array A: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Attention! To multiply array A by array B, the number of rows B ");
Console.WriteLine($"must be equal to the number of columns A (your value = {n1})");
Console.WriteLine();

Console.Write("Input a number of rows of array B: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns of array B: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Input a min possible value (for both arrays): ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value (for both arrays): ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] arrayA = CreateRandom2dArray(m1, n1, min, max);
int[,] arrayB = CreateRandom2dArray(m2, n2, min, max);
Console.WriteLine("Array A:");
Show2dArray(arrayA);
Console.WriteLine("Array B:");
Show2dArray(arrayB);


Console.WriteLine("Array C = A * B:");
if(m2 != n1)
    Console.WriteLine("Arrays can't be multiplied. Check if numbers of rows and columns are correct");
else
{
        int[,] multArray = Multiply2Arrays(arrayA, arrayB);
    Show2dArray(multArray);
}
Console.WriteLine();
*/





