// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

using System;
using static System.Console;
Clear();

WriteLine("Please type a number");


int number = Convert.ToInt32(ReadLine());

WriteLine($"Number of digits:{NumDigits(number)}");

int NumDigits(int N)
{
      int i = 0;
        while (N!=0)
        {
            N=N/10;
            i++;
        }
     
    return i;
}