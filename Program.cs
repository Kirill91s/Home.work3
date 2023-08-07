﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// System.Console.WriteLine("Введите пятизначное число: ");
// string? str = Console.ReadLine(); 

// if (str!.Length != 5)
// {
// System.Console.WriteLine("'это не пятизначное число'!");
// }
// else if (str[0] == str[4] && str[1] == str[3])
// {
//     System.Console.WriteLine("Введённое вами число является палиндромом");
// }
// else
// {
//     System.Console.WriteLine("Введённое вами число не является палиндромом");
// }


﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3, 6, 8); B (2, 1, -7) -> 15.84
// A (7, -5, 0); B (1, -1, 9) -> 11.53

// Реализация с применением конвертации строки, вводимой пользователем, в массив координат точек

// System.Console.WriteLine("Введите через пробел координаты первой точки: ");
// int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

// System.Console.WriteLine("Введите через пробел координаты второй точки: ");
// int[] B = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

// System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(B[0]-A[0], 2)+Math.Pow(B[1]-A[1], 2)+Math.Pow(B[2]-A[2], 2)), 2));


﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= num; i++)
// {
// Console.Write(Math.Pow(i, 3) + " ");
// }