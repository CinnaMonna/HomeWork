// ДЗ1
//Задача 2: Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b) Console.Write("two numbers are equal");

else
{
    int max = a;
    if (a < b) max = b;
    Console.Write("max = " + max); 
}
*/

//Задача 2:Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
/*
int[]array = new int[3];

int i = 0;
while (i < array.Length)
{
    Console.Write("Input a number: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    i +=1;
}

i = 1;
int max = array[0];

while (i < array.Length)
{
    if (array[i] > max)    max = array[i];
    i += 1;
}

Console.Write("max = " + max);

*/











