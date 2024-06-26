﻿// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Задайте размер массива: "); // ввод размера массива
int size = Convert.ToInt32(Console.ReadLine());


int[] numbers = new int[size];                   // Массив для хранения случайных чисел

Random random = new Random();                 // Генератор случайных чисел

int evenCount = 0;                            // Счетчик четных чисел 


for (int i = 0; i < numbers.Length; i++)       // Заполнение массива случайными трехзначными числами
{
    numbers[i] = random.Next(100, 1000);              // Случайное число от 100 до 999

    Console.Write(numbers[i] + " ");               // Вывод сгенерированного числа

    if (numbers[i] % 2 == 0)                  // Проверка на четность и увеличение счетчика
    {
        evenCount++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");  // Вывод количества четных чисел в массиве

