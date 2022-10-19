// ДЗ 2
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

int SecondDigit(int number)
{
    int twoFirstDigits = number % 100;
    int result = twoFirstDigits / 10;
    
    return result;
}

Console.Write("Input 3-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int secondDigit = SecondDigit(num);

Console.WriteLine($"Second digit of {num} is {secondDigit}");
