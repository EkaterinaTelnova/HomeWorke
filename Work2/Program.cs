/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
 int SecondBiggest(int num)
 { 
    int max1 = (num /10);
    int max2 = max1 % 10;
    return max2;
 }
int number = new Random().Next (100,1000);
int sec = SecondBiggest (number);
Console.WriteLine ($"Второе число = {sec} из {number}");
*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
string ThirdDigit(int num)
{
    string result;
    string numAsString = Convert.ToString(num);
    if (numAsString.Length < 3)
        result = "No third digit.";
    else
    {
        char third = numAsString[2];
        result = $"Third digit of {num} is {third}.";
    }
    
    return result;
}
Console.Write("Input number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
string thirdDigit = ThirdDigit(numberB);
Console.WriteLine(thirdDigit);
*/
/*

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool DayHoliday(int day)
{
    bool result;
    if (day == 6 ^ day == 7)
        result = true;
    else
        result = false;
    
    return result;
}
Console.Write("Input a number of the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
bool dayHoliday = DayHoliday(dayNumber);
if (dayHoliday)
    Console.WriteLine($"Да, {dayNumber} день является выходным!");
else
    Console.WriteLine($"Нет, {dayNumber} день - это рабочий день!");
*/