Console.WriteLine("Введите номер задания: ");
int ExNum = int.Parse(Console.ReadLine()!);

switch (ExNum){
    case 1:


//Задание №1
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Введи кол-во строк: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи кол-во столбцов: ");
int columns1 = int.Parse(Console.ReadLine()!);

double[,] Array1 = GetArrayRand(rows1, columns1, -9, 9);
PrintArray1(Array1);

        break;

    case 2:
// Задание №2
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет. Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
///i = 4, j = 2 -> такого числа в массиве нет
//i = 1, j = 2 -> 2

Console.WriteLine("Введи кол-во строк: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи кол-во столбцов: ");
int columns2 = int.Parse(Console.ReadLine()!);

double[,] Array2 = GetArray(rows2, columns2, -9, 9);
PrintArray1(Array2);

Console.WriteLine("Введи номер строки элемента: ");
int iRows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи номер столбца элемента: ");
int jColumns = int.Parse(Console.ReadLine()!);

if(iRows > rows2 || jColumns > columns2) Console.WriteLine($"Элемента с индексами ({iRows},{jColumns}) нет в заданном массиве");

else Console.WriteLine($"Введенный элемент = {Array2[iRows -1, jColumns - 1]}");

        break;

//////////////////////////////////////////////////////////////////////////////////////
//Метод задания двойного рандома (первый целочисленный + второй с точкой от 0 до 1)
double[,] GetArrayRand(int m, int n, int minValue, int maxValue){
    double[,] result1 = new double[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result1[i,j] = new Random().Next(minValue, maxValue - 1) + new Random().NextDouble();
        }
    }
    return result1;
}

//Метод задания обычного рандома
double[,] GetArray(int m, int n, int minValue, int maxValue){
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue - 1);
        }
    }
    return result;
}

//Метод вывода массива через округление Math.Round
void PrintArray1(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{Math.Round(array[i,j], 1), 5} ");
        }
        Console.WriteLine();
    }
}


} //switch