// Найти максимальное из 9 чисел при помощи метода.

int Max(int arg1, int arg2, int arg3)      // объявляем название метода и даем ему переменные
{
    int result = arg1;                     // тело метода, т.е. то, что этот метод (функция)
    if (arg2 > result) result = arg2;      // должен делать: в данном случае, из трех значений
    if (arg3 > result) result = arg3;      // выбрать максимальное и "вернуть" его
                                           // переменные должны отличаться от тех, которые в программе
    return result;
}
int a1 = 15;
int b1 = 20;
int c1 = 35;

int a2 = 45;
int b2 = 24;
int c2 = 31;

int a3 = 15;
int b3 = 17;
int c3 = 38;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max = Max(max1, max2, max3);
Console.WriteLine(max);