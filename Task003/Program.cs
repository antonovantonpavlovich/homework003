/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber (string messege)
{
    int result = 0;
    while(true) 
    {
        Console.WriteLine(messege);

        if(int.TryParse(Console.ReadLine(), out result)) 
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не то число. Повторите");
        }
    }

    return result;
}

int x = GetNumber("Введите число");

for (int i = 1; i <= Math.Abs(x); i++)
{
    Console.Write ($"{Math.Pow(i, 3)}, ");
}