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
/*
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

*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

/*
bool IsItDayOff (int number)
{
    if (number == 6 || number == 7)
        return true;
    else
        return false;
}

Console.Write("Input the number of the day of the week (1 to 7): ");
int num = Convert.ToInt32(Console.ReadLine());

if (IsItDayOff(num) == true)
    Console.WriteLine($"Yes, the day number {num} is a day off");
else
    Console.WriteLine($"No, the day number {num} is not a day off");

*/
