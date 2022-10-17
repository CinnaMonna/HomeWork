// ДЗ1
//Задача 1: Напишите программу, которая на вход принимает два числа 
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

//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)  Console.Write("Yes");
else Console.Write("No");
*/

//Задача 4: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input a number N: ");
int N = Convert.ToInt32(Console.ReadLine());

int a = 1;

while (a <= N)
{
    if (a % 2 == 0)  
    Console.Write(a + "  ");
    a += 1;
}

*/






