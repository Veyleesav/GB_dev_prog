﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter numbers in one line:");
Console.WriteLine(Console.ReadLine().Split(new string[] { ","," " ," ,"," , ","; ",";","; "," ; "}, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).Max());