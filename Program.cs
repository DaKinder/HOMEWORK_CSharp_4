//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.

void UserInput(int[] numbers)
{
    Console.Write("введите целое число: ");
    numbers[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень числа");
    numbers[1] = Convert.ToInt32(Console.ReadLine());
}

int MathPowInt(int[] numbers)
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

int UserEnter()
{
    Console.Write("введите целое число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int CountNumbers(int num)
{
    int sum = 0;
    for (; num > 0; num = num / 10)
    {
        sum += num % 10;
    }
    return sum;
}

int result = CountNumbers(UserEnter());
System.Console.WriteLine($"Результат равен {result}");





//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

int[] CreateArray()
{
    Console.WriteLine("ведите размер массива:");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    return array;
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine("Введите число массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[]array)
{
    Console.Write("Ваш массив: [ ");
    for (int i = 0; i < array.Length -1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]} ]");
}

int[]array = CreateArray();
FillArray(array);
PrintArray(array);
