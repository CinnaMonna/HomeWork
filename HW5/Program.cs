// HW5

// Общие методы, используемые в задачах:

/*
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
*/

// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreateRandomPositiveThreeDigitNumbersArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    
    return array;
}

int CountEvenNumbersOfArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count++;
    
    return count;
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] usersArray = CreateRandomPositiveThreeDigitNumbersArray(size);
ShowArray(usersArray);

Console.WriteLine($"Count of even numbers of array is {CountEvenNumbersOfArray(usersArray)}");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;

}

int GetOddIndexElementsSum(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        sum += array[i];
    
    return sum;
}

Console.Write("Input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] usersArray = CreateRandomArray(n, min, max);
ShowArray(usersArray);

Console.WriteLine($"Sum of elements with odd indices is {GetOddIndexElementsSum(usersArray)}");
*/

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу (разность) между максимальным и минимальным элементами массива.

/*
double[] CreateRandomDoubleTypeNumbersArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        int numbersIntPart = new Random().Next(minValue, maxValue);
        double numbersDoublePart = new Random().NextDouble();
    
        array[i] = Math.Round(Convert.ToDouble(numbersIntPart) + numbersDoublePart, 2);
    }
    
    return array;

}

void ShowDoubleArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "   ");
    
    Console.WriteLine();
}

double FindMaxMinDifference(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(max < array[i]) 
            max = array[i];
        if(min > array[i])
            min = array[i];
    }
    double difference = max - min;
    return difference;
}

Console.Write("Input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input an integer min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input an integer max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] usersArray = CreateRandomDoubleTypeNumbersArray(n, min, max);
ShowDoubleArray(usersArray);

Console.WriteLine($"Difference of max and min elements of the array is {FindMaxMinDifference(usersArray)}");

*/









