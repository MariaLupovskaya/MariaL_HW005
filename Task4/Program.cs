// Задача 4: Задайте массив из 12 случайных чисел. Найдите количество элементов массива, значения которых
// лежат в отрезке [10,99].
// Пример для массива из 5, а не 12 элементов. В своём решении сделайте для 12.

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] array = new int[12];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(0,100);
    Console.Write(array[i] + " ");
    if(array[i] >= 10 && array[i] <= 99)
    {
        sum += 1;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99], равно {sum}");