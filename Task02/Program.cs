//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120

using System;
using static System.Console;
Clear();

WriteLine("Please type a number");

int number = Convert.ToInt32(ReadLine());

WriteLine($"Value:{Result(number)}");



int Result(int N)
{
      int A =1;
      for(int i=1; i<=N; i++)
      {
        A *=i;
      }
      return A;
}