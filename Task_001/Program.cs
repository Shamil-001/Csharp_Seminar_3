﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите число: ");
string num = Console.ReadLine()!;
if (num[0] == num[4] && num[1] == num[3])
{
    System.Console.WriteLine("Число является палиндромом");
}
else 
{
       System.Console.WriteLine("Число не является палиндромом");
}