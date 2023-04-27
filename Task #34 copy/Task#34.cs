// Задача 34: Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void Fill_numbers(int[] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(100, 1000);
    }
}


void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}


void Division(int[] numbers)
{
    int even = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            even=+1;
        }
    }
    Console.WriteLine(even);
}


void Task34()
{
    Console.Write($"Введите количество случайных трехзначных чисел: ");
    int size = int.Parse(Console.ReadLine());
    int[] numbers = new int[size];

    Console.Write($"Имеющиеся числа: ");
    Fill_numbers(numbers);
    PrintArray(numbers);
    Console.Write($"Количество четных чисел: ");
    Division(numbers);
}


Task34();