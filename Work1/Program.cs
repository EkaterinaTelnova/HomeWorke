// Задача 2. Ввести число N. на выходе показать все отрицательные и положительные его значения
/*
Console.WriteLine (" Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + " ");
    current ++;
}
*/

/*
// дз задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write ("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int max = n1;
if (max > n2)
    {
    Console.WriteLine ("max = " + n1);
    }
    else 
    {
    Console.WriteLine ("max = " + n2);    
    }
*/        
// ДЗ 4
/*
Console.Write ("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (n2 > max ) max = n2;
if (n3 > max ) max = n3;
Console.WriteLine ("max = " + max);
*/

Console.Write ("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int even = n % 2;
if (even > 0) 
{
    Console.WriteLine ("нет");
}
else 
    {
    Console.WriteLine ("да");    
    }