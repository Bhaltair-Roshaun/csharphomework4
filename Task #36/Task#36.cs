// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


void Fill_numbers(int[] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(-1000, 1000);
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


void SumNumbers(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + numbers[i];
        }
    }
    Console.WriteLine(sum);
}


void Task36()
{
    Console.Write($"Введите количество случайных чисел: ");
    int size = int.Parse(Console.ReadLine());
    int[] numbers = new int[size];

    Console.Write($"Имеющиеся числа: ");
    Fill_numbers(numbers);
    PrintArray(numbers);
    Console.Write($"Сумма чисел: ");
    SumNumbers(numbers);
}


Task36();