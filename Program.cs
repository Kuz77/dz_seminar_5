
// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами (длина массива 5 элементов). Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array; 
// int arraySize = 5; 
// array = new int[arraySize]; 
// for (int i = 0; i < array.Length; i++) 
// { 
//     int randomNumber = new Random().Next(100, 1000); 
//     array[i] = randomNumber; 
//     Console.WriteLine(array[i] + " "); 
// } 
// int sum = 0; 
// for (int i = 0; i < array.Length; i++) 
// { 
//     if (array[i] % 2 == 0) 
//     { 
//         sum = sum + 1; 
//     } 
// } 
// Console.WriteLine($"четных чисел в массиве: {sum}"); 


// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами (длина массива 5 элементов). Найдите сумму элементов, 
// стоящих на нечётных индексах (индексы с нуля).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array; 
// int arraySize = 5; 
// array = new int[arraySize]; 
// for (int i = 0; i < array.Length; i++) 
// { 
//     int randomNumber = new Random().Next(-100, 101); 
//     array[i] = randomNumber; 
//     Console.Write(array[i] + " "); 
// } 
// int sum = 0; 
// for (int i = 1; i < array.Length; i+=2) 
// { 
//     sum = sum + array[i]; 
// } 

// Console.WriteLine(); 
// Console.WriteLine($"четных чисел на нечетных позициях в массиве равна {sum}"); 

// Задача 38: Задайте массив вещественных чисел от -100 до 100 
// (длина массива 5 элементов). Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int[] array; 
// int arraySize = 5; 
// array = new int[arraySize]; 
// for (int i = 0; i < array.Length; i++) 
// { 
//     int randomNumber = new Random().Next(-100, 101); 
//     array[i] = randomNumber; 
//     Console.Write(array[i] + " "); 
// } 
// int min = 0; 
// int max = 0; 
// int diff; 
// for (int i = 0; i < array.Length; i++) 
// { 
//     if (min > array[i]) 
//     { 
//         min = array[i]; 
//     } 
// } 
// for (int i = 0; i < array.Length; i++) 
// { 
//     if (max < array[i]) 
//     { 
//         max = array[i]; 
//     } 
// } 
// diff = max - min; 
// Console.WriteLine(); 
// Console.WriteLine($"минимальное значиние - {min}"); 
// Console.WriteLine($"максимальное значиние - {max}"); 
// Console.WriteLine($"разница - {diff}"); 

// Доп. задачи
// Задача 3: Задайте массив из 8 случайных чисел из промежутка [-9, 9]. 
// Напишите программу получает на вход число и определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// Console.WriteLine("Вот массив цифр");
// int[] array;
// int arraySize = 8;
// array = new int[arraySize];
// for (int i = 0; i < array.Length; i++)
// {
//     int randomNumber = new Random().Next(-9, 10);
//     array[i] = randomNumber;

//     Console.Write(array[i] + " ");
// }
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < array.Length; i++)
// {
//     if (N == array[i])

//     {
//         Console.WriteLine($"число {N} есть в массиве");
//     }
//     else
//     {
//         Console.WriteLine($"числа {N} нет в массиве");
//     }

// }

// Задача 4: Задайте массив из 10 случайных чисел из промежутка [-100, 100]. Н
// айдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Console.WriteLine("Вот массив чисел (-100 - 100)");
// int[] array;
// int arraySize = 10;
// array = new int[arraySize];
// for (int i = 0; i < array.Length; i++)
// {
//     int randomNumber = new Random().Next(-100, 101);
//     array[i] = randomNumber;

//     Console.Write(array[i] + " ");
// }
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 10 && array[i] < 99)
//     {
//         sum = sum + 1;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"колличество элементов массива в диапазоне 10-99: {sum}");

