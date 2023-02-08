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
















/*Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Алгоритм
1. получить x и y с консоли
2. получить номер четверти, где лежит точка с координатами (x, y)
3. вывести результат на экран
*/
/*
int GetNumber (string messege)
{
    int result = 0;
    while(true) // бесконечный цикл пока не будет введено число не равное 0
    {
        Console.WriteLine(messege);

        if(int.TryParse(Console.ReadLine(), out result) && result != 0) // int.TryParse - из выведенного выражения (string) - преоброзовать в int (out result). если удалось преоброзовать, то результатом будет true - если будет true то мы попадаем на break и выходим на вывод (return) если будет false, то попадаем на else. 
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число или 0. Повторите");
        }
    }


    return result;
}

int GetQuarter (int x, int y)
{
    if (x>0 && y>0)
    return 1;
    else if (x<0 && y>0)
    return 2;
    else if (x<0 && y<0)
    return 3;
    else
    return 4;
}

int x = GetNumber("Введите x отличный от нуля: ");
int y = GetNumber("Введите y отличный от нуля: ");
int quarter = GetQuarter(x, y);

Console.WriteLine($"точка с координатами х = {x}, y = {y}, лежит в {quarter} четверти");
*/
/*
В шарпе есть два типа переменных
1. reference types (ссылочныетипы)
- class, array, list, char 
- хранятся в управляемой куче 
- работаем с их ссылкамит

2. value types (значимые типы)
- int, double, float, decimal, long, bit, byte, struct, enum, datetime
- хранятся в стеке (оперативная память компьютера/сервера/выделяемая память на облаке)
- работаем с их значением
*/

/*
void Temp (int number)
{
    number = number * 10;
}

void Temp1 (int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10);
    }
}

int number = 5;
Temp(number);

//Console.WriteLine (number);

int [] array = new int[8]; // будет 0, 0, 0, 0, 0, 0, 0 - дефолтное значение int будет 0
Console.WriteLine(string.Join(",", array));

Temp1(array);
Console.WriteLine(string.Join(",", array)); // 
*/
//////////////////////////////////////////////
//////////////////////////////////////////////
//////////////////////////////////////////////
/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
int GetNumber (string messege)
{
    int result = 0;
    while(true) // бесконечный цикл пока не будет введено число не равное 0
    {
        Console.WriteLine(messege);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 5) // int.TryParse - из выведенного выражения (string) - преоброзовать в int (out result). если удалось преоброзовать, то результатом будет true - если будет true то мы попадаем на break и выходим на вывод (return) если будет false, то попадаем на else. 
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не существующую четверть. Повторите");
        }
    }


    return result;
}

void GetQuarter (int quarter)
{
    if (quarter == 1)
    Console.WriteLine ("В первой четврти показатели x>0 && y>0");
    else if (quarter == 2)
    Console.WriteLine ("Во второй четврти показатели x<0 && y>0");
    else if (quarter == 3)
    Console.WriteLine ("В третьей четврти показатели x<0 && y<0");
    else
    Console.WriteLine ("В четвертой четврти показатели x>0 && y<0");
}

int quarter = GetNumber("Введите номер четверти: ");
GetQuarter(quarter);
*/
//////////////////////////////////////////////////
//////////////////////////////////////////////////
//////////////////////////////////////////////////
/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
Rjhty
Корень((x1-x2)^2 + (y1-y2)^2)
Math.Sqrt()
Math.Pow(выражение, степень)
*/
/*
int GetNumber (string messege)
{
    int result = 0;
    while(true) // бесконечный цикл пока не будет введено число не равное 0
    {
        Console.WriteLine(messege);

        if(int.TryParse(Console.ReadLine(), out result)) // int.TryParse - из выведенного выражения (string) - преоброзовать в int (out result). если удалось преоброзовать, то результатом будет true - если будет true то мы попадаем на break и выходим на вывод (return) если будет false, то попадаем на else. 
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не существующую четверть. Повторите");
        }
    }


    return result;
}

int x1 = GetNumber ("Введите координату Х первой точки");
int y1 = GetNumber ("Введите координату Y первой точки");
int x2 = GetNumber ("Введите координату Х второй точки");
int y2 = GetNumber ("Введите координату Y второй точки");

double GetDistance (int x1, int x2, int y1, int y2)
{
     double result = Math.Sqrt (Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));
     return result;
}

Console.WriteLine(GetDistance(x1, x2, y1, y2));
*/
///////////////////////////////////////////////
///////////////////////////////////////////////
///////////////////////////////////////////////
/*
Задача
Напишите программу, которая принимает на вход число (N)
и выдает таблицу квадратов чисел от 1 до N
*/
/*
int GetNumber (string messege)
{
    int result = 0;
    while(true) // бесконечный цикл пока не будет введено число не равное 0
    {
        Console.WriteLine(messege);

        if(int.TryParse(Console.ReadLine(), out result)) // int.TryParse - из выведенного выражения (string) - преоброзовать в int (out result). если удалось преоброзовать, то результатом будет true - если будет true то мы попадаем на break и выходим на вывод (return) если будет false, то попадаем на else. 
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
    Console.Write ($"{Math.Pow(i, 2)}, ");
}
*/


/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает 
наибольшую цифру числа.

Например
78 -> 8
12 -> 2
85 -> 8

1. получить рандомное число в диапозоне [10, 99]
2. получить максимальную цифру числа
*/
// получить рандомное число в диапозоне [10, 99]
/*
int GetNumber()
{
    Random rnd = new Random();
    int result = rnd.Next(10, 100); // [left, right) -> [10, 100) -> [10, 99]
    return result;
}
// получить максимальную цифру числа
int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
    return firstDigit;
    else
    return secondDigit;
}

int number = GetNumber();
int maxDigit = GetMaxDigitOfNumber(number);
Console.WriteLine ($"максимальная цифра числа {number} = {maxDigit}");
*/
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////

/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/
/*
Решил сам
int GetNumber()
{
    Random rnd = new Random();
    int result = rnd.Next(100, 1000); // [left, right) -> [100, 1000) -> [100, 999]
    return result;
}
int number = GetNumber();
    int a = number / 100;
    int b = number % 10;

Console.WriteLine ($"{number} -> {a}{b}");
*/
/* решение на уроке
int GetNumber()
{
    Random rnd = new Random();
    int result = rnd.Next(100, 1000); // [left, right) -> [10, 100) -> [10, 99]
    return result;
}
// получить максимальную цифру числа
int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;

    return firstDigit * 10 + secondDigit;
}

int number = GetNumber();
int maxDigit = GetMaxDigitOfNumber(number);
Console.WriteLine ($"{number} -> {maxDigit}");
*/
///////////////////////////////////
///////////////////////////////////
///////////////////////////////////
/*
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

/*
int GetNumber(string message)
{
Console.WriteLine(message);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}

int numberA = GetNumber ("Введите первое число");
int numberB = GetNumber ("Введите второе число");

if (numberA % numberB == 0)
{
    Console.WriteLine ($"{numberA}, {numberB} -> кратно");
}
else
{
    Console.WriteLine ($"{numberA}, {numberB} -> не кратно, остаток {numberA % numberB}");
}
*/
///////////////////////////////////
///////////////////////////////////
///////////////////////////////////
/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
7 и 23.

14 -> нет
46 -> нет
161 -> да
*/
/*
int GetNumber(string message)
{
Console.WriteLine(message);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}

int numberA = GetNumber ("Введите число");

if (numberA % 7 == 0 && numberA % 23 == 0)
{
    Console.WriteLine ($"{numberA} -> да");
}
else
Console.WriteLine ($"{numberA} -> нет");
*/
///////////////////////////////////
///////////////////////////////////
///////////////////////////////////
/*
Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/
/*
int GetNumber(string message)
{
Console.WriteLine(message);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}

int numberA = GetNumber ("Введите первое число");
int numberB = GetNumber ("Введите второе число");

if (numberA * numberA == numberB || numberB * numberB == numberA)
{
    Console.WriteLine ($"{numberA}, {numberB} -> да");
}
else
{
    Console.WriteLine ($"{numberA}, {numberB} -> нет");
}
*/