// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] array = new int[4];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(100,1000);
    Console.Write(array[i] + " ");
    int currentNumber = array[i];
    if(currentNumber % 2 == 0)
    {
        sum += 1;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве равно {sum}");