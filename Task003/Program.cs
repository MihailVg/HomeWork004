// Задача N3 Напишите метод(ы), которай задаёт массив из 8 элементов и выводит их на экран.

void Method1(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 100);
        index++;
    }
}

void Method2(int[] array1)
{
    int count = 0;
    int leng = array1.Length;

    while(count < leng)
    {
        Console.Write(array1[count] + " ");
        count++;
    }
}

int[] array2 = new int[8];

Method1(array2);
Method2(array2);