/*
Задача1
int randomNumber = new Random().Next(10, 100);
int num1 = randomNumber % 10;
int num2 = randomNumber / 10;
System.Console.WriteLine($" Выбрано число: {randomNumber}"); // Строковая интерполяция
System.Console.WriteLine(num1 > num2 ? num1 : num2);


Задача 2
int randmNumber = new Random().Next(100, 1000);
System.Console.WriteLine(randmNumber);
System.Console.WriteLine((randmNumber / 100) * 10 + (randmNumber % 10));

задача 3
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
*/

int num1 = 4;
int num2 = 16;

if (Math.Pow(num1, 2) == num2)
{
    System.Console.WriteLine("является");
    return;
}

if (Math.Pow(num2, 2) == num1)
{
    System.Console.WriteLine("является");
    return;
}
else
{
    System.Console.WriteLine("не является");
}