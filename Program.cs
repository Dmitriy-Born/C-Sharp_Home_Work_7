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

double[,] Array1 = GetArray(rows1, columns1, -9, 9);
PrintArray(Array1);


//Метод задания двойного рандома (первый целочисленный + второй с точкой от 0 до 1)
double[,] GetArray(int m, int n, int minValue, int maxValue){
    double[,] result1 = new double[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result1[i,j] = new Random().Next(minValue, maxValue - 1) + new Random().NextDouble();
        }
    }
    return result1;
}

//Метод вывода массива через округление Math.Round
void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{Math.Round(array[i,j], 1), 5} ");
        }
        Console.WriteLine();
    }
}