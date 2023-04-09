// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

void Sum(int M, int N, int nextNumber)
{
    if (M > N)
    {
        Console.WriteLine(nextNumber);
        return;
    }
    nextNumber = nextNumber + (M++);
    Sum(M, N, nextNumber);
}

Sum(M, N, 0);
