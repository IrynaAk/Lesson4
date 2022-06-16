// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. 
//- через метод FillArray
// [1,0,1,1,0,1,0,0]
//int[] ar=new int[8];
//FillArray(int[] array)



using System;
using static System.Console;
Clear();

int[] newArray = FillArray(new int[8]);
WriteLine($"Random array: {newArray[0]}, {newArray[1]}, {newArray[2]}, {newArray[3]}, {newArray[4]}, {newArray[5]}, {newArray[6]}, {newArray[7]}");


int[] FillArray(int[] array)

{
    int[] ar=new int[8];

    for(int i = 0; i<8; i++)
    {
        ar[i] = new Random().Next(0,2);
    }
    return ar;

}



//Показывал преподаватель:
// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }

//WriteLine(String.Join("," array))

