//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
//вариант 1


while (true) //содаем бесконечный цикл true
{
    Console.Write("Введите целое число или 'q' для выхода: ");
    string input = Console.ReadLine();

    if (input == "q") //условие если
    {
        Console.WriteLine("ввели q [STOP]");//если ввели q то стоп программа
        break;
    }

    if (int.TryParse(input, out int number))// вводим цикл если TryParse (является вводное слово - числом)
    {
        if (IsSumOfDigitsEven(number))//вводим цикл если,вызывая логическую функцию  IsSumOfDigitsEven
        {
            Console.WriteLine("Сумма цифр числа четна. Программа завершена.");//если сумма цифр четна -стоп программа
            break;
        }
    }

}

static bool IsSumOfDigitsEven(int number)// создали логическую функцию   определения чётности суммы цифр
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum % 2 == 0;
}
Console.WriteLine("[Решение 2]");

while (true)                                       // Бесконечный цикл
{
    Console.Write("Введите число или 'q' для выхода: ");
    string input = Console.ReadLine();                // Чтение строки ввода пользователя

    if (input == "q")                                // Проверка на ввод 'q' для выхода
    {
        Console.WriteLine("ввели q [STOP]");
        break;
    }
    int number;
    if (int.TryParse(input, out number))             // Проверка, является ли ввод числом
    {
        int sum = 0;
        while (number > 0)                              // Вычисление суммы цифр числа
        {
            sum += number % 10;                            // Добавление последней цифры к сумме
            number /= 10;                                  // Удаление последней цифры из числа
        }
        if (sum % 2 == 0)                              // Проверка, является ли сумма цифр четной
        {
            Console.WriteLine("Сумма чётна.[STOP]");
            break;
        }
    }
}



