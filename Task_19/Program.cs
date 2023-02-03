// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();
string num1 = Convert.ToString(num[0]);
string num2 = Convert.ToString(num[1]);
string num4 = Convert.ToString(num[3]);
string num5 = Convert.ToString(num[4]);
if (num1==num5 && num2==num4)
{
    Console.WriteLine($"Число является палиндромом");
}
else
{
    Console.WriteLine($"Число не является палиндромом");
}
