// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreateRandomArray(int size)
{
    int[] array = new int [size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) 
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Even(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
    if(array[i] % 2 == 0)
    count++;
    }
    return count;

}

Console.Write("Input a number of elements : ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray);
 
int even = Even(myArray);
Console.WriteLine("В данном массиве" + " " + even + " " + "четных элементов");
*/

// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size)
{
    int[] array = new int [size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 100);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) 
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Summ(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        sum = sum + array[i];
    } 
    return sum;
}

Console.Write("Input a number of elements : ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray);

int rezult = Summ(myArray);
Console.WriteLine(rezult);
*/
 
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.

double[] CreateRandomArray(int size)
{
    double[] array = new double [size];

    for(int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() + new Random().Next(1, 100), 2);

    }
return array;


}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++) 
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double DiffMaxAndMin(double[] array)
{
double dif = 0;
    for(int i = 1; i < array.Length; i++)
    {
        double min = array[0];
        double max = array [0];
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
        dif = max - min;
    }
   return dif;
}



Console.Write("Input a number of elements : ");
int length = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(length);
ShowArray(myArray);

double dif = DiffMaxAndMin(myArray);
Console.WriteLine(dif);
