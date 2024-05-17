//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


bool IsSumNumEven(int num)
{
    //int numCopy = num;
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }

    if (sum % 2 != 0)
    {
        return false;
    }
    return true;
}

Console.Write("Введите целое число: ");
string nums = "";
while (true)
{
    string? data = Console.ReadLine();
    if (data == "q")
    {
        Console.Write($"{nums} q [STOP]");
        break;
    }

    int num = Convert.ToInt32(data);

    if (IsSumNumEven(num))
    {
        Console.Write($"{nums} {num} [STOP]");
        break;
    }
    nums = nums + " " + num;
}

Console.WriteLine();


while (true)
{
    Console.Write("Введите целое число или 'q' для выхода: ");
    string input = Console.ReadLine();

    if (input == "q")
    {
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
    else
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
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