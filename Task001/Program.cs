// Задача N1 Напишите метод, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

void Method(int A, int B)
{
    int count = 1;
    int C = A;
    while(count < B)
    {
        A = A * C;
        count++;
    }
}


