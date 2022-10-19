// ДЗ 2
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

/*
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
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

int ConvertToThreeDigit(int number)
{
    int result;
    if (number / 100 == 0)
        result = -1;
    else
    {
        while (number / 1000 != 0)
            number = number / 10;
        
        result = number;   
    }
    return result;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int threeDigitNum = ConvertToThreeDigit(num);

if (threeDigitNum == -1)
    Console.WriteLine($"number {num} doesn't have a third digit");
else
    Console.WriteLine($"Third digit of {num} is {threeDigitNum % 10}");


