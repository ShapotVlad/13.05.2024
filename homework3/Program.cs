// Задача 3: Напишите программу,
// которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

Console.WriteLine("Задайте размер массива: "); // ввод размера массива
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];                   // Массив для хранения случайных чисел

Random random = new Random();                 // Генератор случайных чисел

Console.Write("Сгенерированный массив: ");
for (int i = 0; i < numbers.Length; i++)       // Заполнение массива случайными трехзначными числами
{
    numbers[i] = random.Next(10, 100);              // Случайное число от 10 до 99

    Console.Write(numbers[i] + " ");               // Вывод сгенерированного массива
}

int temp;

for (int i = 0; i < numbers.Length / 2; i++)  // Реверсирование массива
{
    temp = numbers[i];                            // Меняем местами элементы
    numbers[i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = temp;
}

Console.WriteLine();

Console.Write("Перевернутый    массив: "); // Вывод измененного массива
foreach (int number in numbers)
{
    Console.Write(number + " ");
}



