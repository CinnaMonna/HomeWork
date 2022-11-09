// HW4
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
double RaiseToPower(double num, int pow)
{
    double res;
    if(pow == 0)
        res = 1;
    else
    {
        res = num;
        for(int cur = 2; cur <= pow; cur++)
            res = res * num;
    }
    return res;
}

Console.Write("input a number: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("input a integer power: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"number {a} raised to the power of {b} is {Math.Round(RaiseToPower(a, b), 2)}");
*/

// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
int CountOfDigits(int num)
{
    int res;
    if(num == 0)
        res = 1;
    else
    {
        res = 0;
        while(num != 0)
        {
            num = num / 10;
            res++;
        }
    }    
    return res;
}


int SumOfDigits(int num)
{
    int digitsCount = CountOfDigits(num);
    int digit;
    int sum = 0;
    
    while(digitsCount != 0)
    {
        digit = num / Convert.ToInt32(Math.Pow(10, digitsCount - 1));
        sum = sum + digit;
        num = num % Convert.ToInt32(Math.Pow(10, digitsCount - 1));
        digitsCount -= 1;
    }
    return sum;
}

Console.Write("input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits of the number {number} is {SumOfDigits(number)}");

*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*

int[] CreateUsersArray (int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());

    return array; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();
}

Console.Write("input a size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input elements of the array: ");

int[] array = CreateUsersArray(size);
Console.Write("created array: ");
ShowArray(array);

*/

