//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

int x = Convert.ToInt32(Console.ReadLine());
if (x>=1 && x<=5)
Console.WriteLine("Нет");
else if (x>=6 && x<=7)
Console.WriteLine("Да");
else if (x>7 || x<1)
Console.WriteLine("Введите число от 1 до 7");