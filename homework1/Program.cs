//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

while (true)
{
    Console.Write("Введите целое число или 'q' для выхода: ");
    string input = Console.ReadLine();

    if (input == "q")
    {
        Console.WriteLine("ввели q [STOP]");
        break;
    }

    if (int.TryParse(input, out int number))
    {
        if (IsSumOfDigitsEven(number))
        {
            Console.WriteLine("Сумма цифр числа четна. Программа завершена.");
            break;
        }
    }

}

static bool IsSumOfDigitsEven(int number)
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



