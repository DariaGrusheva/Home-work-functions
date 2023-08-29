// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int Readnumber(string text)
{
    Console.Write(text);
    string numberstr = Console.ReadLine();
    int number = Int32.Parse(numberstr);
    return number;
}

int num1 = Readnumber("Введите первое число: ");
int num2 = Readnumber("Введите второе число: ");
int num3 = Readnumber("Введите третье число: ");
int num4 = Readnumber("Введите четверное число: ");
int num5 = Readnumber("Введите пятое число: ");
int num6 = Readnumber("Введите шестое число: ");
int num7 = Readnumber("Введите седьмое число: ");
int num8 = Readnumber("Введите восьмое число: ");
Console.WriteLine($"[{num1}, {num2}, {num3}, {num4}, {num5}, {num6}, {num7}, {num8}]");