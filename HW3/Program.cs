// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 
// Решение для числа с любым количеством разрядов (не только 5):

/*

int DigitsCount (int number)                              // метод для определения количества разрядов в числе
{
    int res = 0;
    
    while (number != 0)
    {
        number = number / 10;
        res++;
    }
    
    return res;
}

bool IsItPalindrome (int number)                          // пример: число 1234321
{
    int digitsCount = DigitsCount(number);                // кол-во разрядов в числе  --> 7
   
    while (digitsCount > 1)
    {
        int firstDigit = number / Convert.ToInt32(Math.Pow(10, digitsCount - 1));    //  первая цифра --> 1234321 / 10^6 = 1 
        int lastDigit = number % 10;                                                 //  послед. цифра --> 1 

        if (firstDigit == lastDigit)                                                 // если 1я и посл. равны, отсекаем их
        {
            number = number % Convert.ToInt32(Math.Pow(10, digitsCount - 1));        // отсекли первую --> 1234321 % 10^6 = 234321
            number = number / 10;                                                    // отсекли последнюю --> 234321 / 10 = 23432
            digitsCount -= 2;                                                        // кол-во разрядов убавилось на 2 --> 5
        }
        else return false;
    }
    return true;

}

Console.Write("input any integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (IsItPalindrome(num) == true)
    Console.WriteLine($"Yes, number {num} is a palindrome");
else 
    Console.WriteLine($"No, number {num} is not a palindrome");


*/

