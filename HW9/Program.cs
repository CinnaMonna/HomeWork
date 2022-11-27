// HW9
// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumbers(int number)
{
    if(number >= 1)
    {
        Console.Write(number + " ");
        ShowNumbers(number - 1);
    }
}

Console.Write("Input the positive integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
/*
int SumOfNumbersInRange(int number1, int number2)
{
    if(number1 < number2)
        return SumOfNumbersInRange(number1 + 1, number2) + number1;
    
    else if(number1 > number2)
        return SumOfNumbersInRange(number1, number2 + 1) + number2;
    
    else return number1;                                                                                                                                                                                                  
}

Console.Write("Input the first positive integer number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second positive integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfNumbersInRange(m, n));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
/*
int AkkermanFunc(int number1, int number2)
{
    if(number1 == 0)
        return number2 + 1;
    else if(number1 > 0 && number2 == 0)
        return AkkermanFunc(number1 - 1, 1);
    else
        return AkkermanFunc(number1 - 1, AkkermanFunc(number1, number2 - 1));
}

Console.Write("Input the first non-negative number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second non-negative number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AkkermanFunc(m, n));
*/



