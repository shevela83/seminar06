// **Задача 40:**Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.

int A = asknum("A");
int B = asknum("B");
int C = asknum("C");
Tranglecheck(A, B, C);

int asknum (string name)
{
    Console.Write($"Введите число {name}: ");
    int n = int.Parse(Console.ReadLine()!);
    return n; 
}

//A+B > C; A+C > B ; B+C > A;

void Tranglecheck (int A, int B, int C)
{
    if (A+B > C && A+C > B && B+C > A )
    {
        Console.WriteLine("Треугольник существует");
    }
    else Console.WriteLine("Не треугольник");
}
