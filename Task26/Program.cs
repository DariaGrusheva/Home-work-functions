// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Massege()
{
    Console.WriteLine("Введите целое число");
    string msg = Console.ReadLine();
    int number = Int32.Parse(msg);
    return number;
}


int Sum(int number)
{
    number = Math.Abs(number);
    int remainder = 0;
    while (number / 10 > 0)
    {
        remainder = number % 10 + remainder;
        number = number / 10;
    }
    if (number / 10 == 0) remainder = remainder + (number % 10);

    return remainder;
}

int num = Massege();
int sum = Sum(num);
Console.WriteLine($"Сума цифр чила {num} равна {sum}.");


