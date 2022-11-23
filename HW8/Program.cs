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



