﻿//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.

void UserInput(int[]numbers)
{
    Console.Write("введите целое число: ");
    numbers[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень числа");
    numbers[1] = Convert.ToInt32(Console.ReadLine());
}

int MathPowInt(int [] numbers)
{
    int multiplier = numbers[0];
    for (int i = 1; i < numbers[1]; i++)
    {
        numbers[0] = numbers[0] * multiplier;
    }
    return numbers[0];
}
int[] numbers = new int[2];
UserInput(numbers);
System.Console.WriteLine($"Ответ: {MathPowInt(numbers)}");

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.