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
Console.WriteLine("---------------Задание №1---------------");
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
Console.WriteLine("---------------Задание №2---------------");
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

    case 3:
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("---------------Задание №3---------------");
Console.WriteLine("Введи кол-во строк: ");
int rows3 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи кол-во столбцов: ");
int columns3 = int.Parse(Console.ReadLine()!);

double[,] Array3 = GetArray(rows3, columns3, -9, 9);
PrintArray1(Array3);
Console.Write("Среднее арифметическое каждого столбца: ");

int j = 0;
double sum = 0;
while (j <= rows3){
    for (int i = 0; i < Array3.GetLength(0); i++){
        sum += Array3[i,j] / rows3;       
          
    }
    Console.Write($"{sum}; ");
    sum = 0;
    j++;
}
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


//////////////////////////////////////////////////////////////////////////////////
//Решение дополнительных заданий

    case 4:
//Задача №4
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
Console.WriteLine("---------------Задание №4---------------");
Console.WriteLine("Введи кол-во элеметов по x: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи кол-во элементов по y: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи кол-во элементов по z: ");
int z1 = int.Parse(Console.ReadLine()!);

int[, ,] Array4 = GetArray3(x1, y1, z1, 10, 100);
PrintArray3(Array4);

//Метод задания одномерного массива с уникальными значениями и заполнение этими значениями трехмерного массива 
int[, ,] GetArray3(int m, int n, int l, int minValue, int maxValue){
    int size = m * n * l;
    int[] array = new int [size];
    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(minValue,maxValue - 1);
    }  
        for (int sr = 0; sr <  array.Length - 1; sr ++){
            int comp = 0;
            while(comp < array.Length - 1){
                if(array[comp] == array[sr]){
                array[comp] = new Random().Next(minValue, maxValue - 1);
                comp++;
                }
                else comp++;        
            }      
        }
    
    Console.Write(String.Join(", ", array));

    Console.WriteLine();
    
    int[, ,] result = new int[m,n,l];

    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            for(int k = 0; k < l; k++){
            result[i,j,k] = array[k + 3 * j + 9 * i];                    
            }
        }
    }
    return result;
}

//Метод вывода трехмерного массива с индексом элемента
void PrintArray3(int[, ,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int k = 0; k < array.GetLength(2); k++){
            Console.Write($"{array[i,j,k], 5}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }        
    }
}

        break;

    case 5:
//Задание №5
//Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
Console.WriteLine("---------------Задание №5---------------");
Console.WriteLine("Введите размерность квадратной матрицы");
int Square = int.Parse(Console.ReadLine()!);
int[,] spin = new int[Square,Square];
ArraySpinPaint(spin, Square);
PrintArray(spin);

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if (array[i,j] < 10) Console.Write($"0{array[i,j]} ");
            else Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

//Метод заполнения по спирали
int[,] ArraySpinPaint(int[,] array, int sq){
int number = 1;
for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
        while(number <= sq*sq){
            array[i,j] = number;
            if (i <= j + 1 && i + j < sq - 1)  j++;
            else if (i < j && i + j >= sq - 1) i++;
            else if (i >= j && i + j > sq - 1) j--;
            else i--;
            number++;
        }   
    }
}
return array;
}

        break;
   
    default:
    Console.WriteLine("Такого задания не делали");
        break;
} //switch


