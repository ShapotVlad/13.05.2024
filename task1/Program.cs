// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом массиве.
// Примеры
// [1 3 4 19 3] => 2
// // [4 3 4 1 9 5 21 13] => 3

int[] CreateArrayRndInt(int size, int min, int max) //задали одномерный массив заполненный случайными числами 
{                                                   //с помощью возвратной функции  int[]  
    int[] array = new int[size];
    Random rnd = new Random();                      //заполняем случайными числами методом Next

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)                       //выводим на консоль с помощью безвозратной функции
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

int CountPrimeNumbers(int[] array)                  //вводим возвратную функцию для подсчета простых чисел 
{
    int count = 0;
 // реализация
    for (int i = 0; i < array.Length; i++)
    {
        if(IsPrime(array[i]))                       // через введенную ниже логическую функцию IsPrime добавляем простые числа
        {
            count++;
        }
    }

    return count;
}

bool IsPrime(int num)                              //вводим логическую функцию проверки является ли число простое, делим на i число  
{
    for (int i = 2; i <= Math.Sqrt(num); i++)      //проверяем от числа 2 до корня квадратного числа
    {
        if(num % i == 0) 
        {
            return false; 
        }
    }
    return true;
}

int[] arr = CreateArrayRndInt(13, 1, 100);         //вводим параметры массива  в функцию
PrintArray(arr);                                   //выводим  массив

int countPrime = CountPrimeNumbers(arr);           // выводим количество простых чисел
Console.Write($" => {countPrime}");