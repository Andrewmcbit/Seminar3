/* Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
Найдите разницу между максимальным и минимальным элементов массива. */

double[] array = new double[10]; 
for (int i = 0; i < array.Length; i++){
    array[i] = (new Random().NextDouble()) + (new Random().Next(-10,10)); // 
    Console.Write($"{array[i]} ");
}
double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++){
    if (array[i] > max){
        max = array[i];
    }
    if (array[i] < min){
        min = array[i];
    }
}
Console.Write($"\nРазница между максимальным и минимальным значением: {max - min}");