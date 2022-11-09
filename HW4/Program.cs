// HW4
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double RaiseToPower(double num, int pow)
{
    double res = num;
    for(int cur = 2; cur <= pow; cur++)
        res = res * num;
    return res;
}

Console.Write("input a number: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("input a integer power: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"number {a} raised to the power of {b} is {Math.Round(RaiseToPower(a, b), 2)}");

