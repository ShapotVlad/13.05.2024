

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