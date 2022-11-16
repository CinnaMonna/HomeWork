// HW6
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
bool IsEvenNumber(double number)
{
    if(number > 0) return true;
    else return false;
}

Console.Write("Input a count of numbers: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers:");

int countEven = 0;
for(int i = 1; i <= count; i++)
{
    double num = Convert.ToDouble(Console.ReadLine());
    if(IsEvenNumber(num))  countEven++;
}
Console.WriteLine($"Count of even numbers is {countEven}");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
/*
double GetIntersectionsAbscissa(double k1, double b1, double k2, double b2)
{
    double res = (b2 - b1) / (k1 - k2);
    return res;
}
double GetIntersectionsOrdinate(double xIntersection, double k1, double b1)
{
    double res = k1 * xIntersection + b1;
    return res;
}

Console.WriteLine("Input values k1 and b1 for setting " + 
        "the equation y = k1 * x + b1 of the first straight line:");
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input values k2 and b2 for setting " + 
        "the equation y = k2 * x + b2 of the second straight line:");
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2 && b1 != b2)
{
    Console.WriteLine("Straight lines with equations ");
    Console.WriteLine($"y = ({Math.Round(k1, 2)}) * x + ({Math.Round(b1, 2)}) and  " +
    $"y = ({Math.Round(k2, 2)}) * x + ({Math.Round(b2, 2)}) ");
    Console.WriteLine("are parallel and don't intersect");
}
else if(k1 == k2 && b1 == b2)
{
    Console.WriteLine("Straight lines with equations ");
    Console.WriteLine($"y = ({Math.Round(k1, 2)}) * x + ({Math.Round(b1, 2)}) and  " +
    $"y = ({Math.Round(k2, 2)}) * x + ({Math.Round(b2, 2)}) ");
    Console.WriteLine("coincide");
}
else
{
    double xIntersection = GetIntersectionsAbscissa(k1, b1, k2, b2);
    double yIntersection = GetIntersectionsOrdinate(k1, xIntersection, b1);
    
    Console.WriteLine("Coordinates of the point of intersection of straight lines with equations:");
    Console.WriteLine($"y = ({Math.Round(k1, 2)}) * x + ({Math.Round(b1, 2)}) and  " +
    $"y = ({Math.Round(k2, 2)}) * x + ({Math.Round(b2, 2)}) ");
    Console.WriteLine($"x = {Math.Round(xIntersection, 2)}; y = {Math.Round(yIntersection, 2)}");
}
*/

