﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// -------------------------------
// System.Console.Write("Введите первое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// if (numA > numB){
//     System.Console.WriteLine($"Число {numA} больше числа {numB}");
// }
// else if (numB > numA){
//     System.Console.WriteLine($"Число {numB} больше числа {numA}");
// }
// else{
//     System.Console.WriteLine($"Число {numA} равно числу {numB}");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
System.Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());

int [] i = {numA, numB, numC};
int maxValue = i.Max();

System.Console.WriteLine(maxValue);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8