﻿// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом массиве.
// Примеры
// [1 3 4 19 3] => 2
// // [4 3 4 1 9 5 21 13] => 3

int[] CreateArrayRndInt(int size, int min, int max) //создали локальную функцию заполненный случайными числами массив
{                                                     
    int[] array = new int[size];                    //массив для хранения случайных чисел
    Random rnd = new Random();                      //вводим генератор случайных чисел

    for (int i = 0; i < size; i++)                   //цикл заполнения числами массива
    {
        array[i] = rnd.Next(min, max);            //заполняем случайными числами методом Next
    }

    return array;                                   //возврат в переменную массива
}

void PrintArray(int[] array)                       //создали безвозратную  функцию вывода на консоль массива
{                                                  //в квадратных скобках через запятую, последнее число без запятой
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)                 // отделяем  числа запятой
        {
            Console.Write($"{array[i]}, ");
        }
        else                                      //посде последнего числа запятую не ставим
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

int CountPrimeNumbers(int[] array)                  //создали возвратную функцию для подсчета простых чисел 
{
    int count = 0; //вводим счётчик чисел
 // реализация
    for (int i = 0; i < array.Length; i++)         //цикл подсчета count
    {
        if(IsPrime(array[i]))                       // через введенную ниже логическую функцию IsPrime добавляем простые числа
        {
            count++;
        }
    }

    return count;    //возврат впеременную подсчёта простых чисел
}

bool IsPrime(int num)                              //вводим логическую функцию проверки является ли число простое, делим на i число  
{
    for (int i = 2; i <= Math.Sqrt(num); i++)      //цикл проверки на простое число и проверяем от числа 2 до корня квадратного числа
    {
        if(num % i == 0) // если число делиться без остатка на итое число, то итое число  не простое
        {
            return false; 
        }
    }
    return true; // впротивном случае  простое
}

int[] arr = CreateArrayRndInt(13, 1, 100);         //вызываем локальную функцию и вводим параметры массива  в функцию
PrintArray(arr);                                   //вызываем функцию и выводим  массив

int countPrime = CountPrimeNumbers(arr);           // вызываем функцию и выводим количество простых чисел
Console.Write($" => {countPrime}");