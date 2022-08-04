// Задача N2 Напишите метод, которая принимает на вход число и выдаёт сумму цифр в числе.

void Method(int A)
{
    int B = 10;
    int result = 0;
    while(A > B)
    {
        result = result + A%10;
        A = A/10;
    }
    result = result + A;
    Console.WriteLine(result);
}
