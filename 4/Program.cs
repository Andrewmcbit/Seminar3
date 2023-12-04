/*Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
Создайте массив, состоящий из цифр этого числа. 
Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
Размер массива должен быть равен количеству цифр. Пример: 8741 => [8 7 4 1]*/

int number = new Random().Next(1,100000);
Console.Write($"Число {number} -> ");

if (number < 10){
    Console.Write($"{number}");
} else {
    int length = 0;
    int temp = number;
    while (temp > 0){
        temp /= 10;
        length++;
    }
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++){
        array[array.Length - 1 - i] = number % 10;
        number /= 10;
    }
    Console.Write("[");
    for (int i = 0; i < array.Length; i++){
        if (i < array.Length - 1){
            Console.Write(array[i] + " ");
        } else {
            Console.Write(array[i] + "]");
        }
    }
}