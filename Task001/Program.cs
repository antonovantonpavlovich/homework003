/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int GetNumber (string messege)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(messege);

        if(int.TryParse(Console.ReadLine(), out result) && result > 9999 && result < 100000)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не пятизначное число. Повторите");
        }
    }


    return result;
}

int number = GetNumber ("Введите пятизначное число");

int firstDigit = number / 1000;
int secondDigit = number % 100;

if ((firstDigit+9) == secondDigit)
Console.WriteLine ($"{number} -> да");
else
Console.WriteLine ($"{number} -> нет");
