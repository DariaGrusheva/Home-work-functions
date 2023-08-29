//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Readnumber(string text)
{
    Console.Write(text);
    string numberstr = Console.ReadLine();
    int number = Int32.Parse(numberstr);
    return number;
}

double Degree(double A, double B)
{
    double degree = A;
    if (B == 1) return A;
    else if (B == 0) return 1;
    else if (B > 0)
    {
        for (int i = 2; i <= B; i++)
        {
            degree = degree * A;
        }
    }
    else
    {
        for (int i = 2; i <= -B; i++)
        {
            degree = 1 / (degree * A);
        }
    }
    return degree;
}

int a = Readnumber("Введите основание степени: ");
int b = Readnumber("Введите показатель степени: ");

double degree = Degree(a, b);
Console.WriteLine($"Число {a} в степени {b} равно {degree}");

