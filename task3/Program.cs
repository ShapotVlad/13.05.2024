// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int[] CreateArrayRndInt(int size, int min, int max) //создали функцию для создание массива случайных чисел ль 0 до 9 
{
    int[] array = new int[size]; //массив для хранения случайных чисел

    Random rnd = new Random(); //генератор случайных чисел

    for (int i = 0; i < size; i++) //цикл заполнения массива случайными числами
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array) //воздали функцию для вывода массива на консоль
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) //цикл для вывода случайных чисел массива
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else                                //отсутствие запятой после последнего числа массива
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

int ArrayToNumber(int[] array)   //создали функцию для перевода  массива в целое число
{
    int res = 0;
    for (int i = 0; i < array.Length; i++) //цикл перевода чисел массива в число
    {
        res = res * 10 + array[i];
    }

    return res;
}

Console.WriteLine("Задайте размер массива: "); // ввод размера массива
int n = Convert.ToInt32(Console.ReadLine());

if(n < 1 || n > 8 )                           // проверка, чтобы число массива было от 1 до 8
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

int[] arr = CreateArrayRndInt(n, 0, 10); //ввод параметров функции создание массива
PrintArray(arr);                         //ввод параметров вывода массива на консоль 

int result = ArrayToNumber(arr);         //вывод числа на  консоль  
Console.WriteLine($" => {result}");