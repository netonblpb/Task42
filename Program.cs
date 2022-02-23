// Определить, сколько чисел больше 0 введено с клавиатуры.

Console.Clear();

Console.Write("Введите количество чисел: ");
int count = int.Parse(Console.ReadLine());

int more = 0;
int num;

for (int i = 1; i <= count; i++)
{
    Console.Clear();
    Console.Write($"Введите {i} число: ");
    num = int.Parse(Console.ReadLine());

    if (num > 0) more++; 

}

Console.WriteLine($"Вы ввели {more} чисел больше 0");