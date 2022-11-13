// HW5

// Общие методы, используемые в задачах:

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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




