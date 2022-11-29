// Задача 3: Задайте массив из 8 случайных чисел. Напишите программу, которая определяет, присутствует
// ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(1,1000);
    Console.Write(array[i] + " ");
}
    Console.WriteLine();
    Console.WriteLine("Введите число");
    string str = Console.ReadLine();
    int countNumber = int.Parse(str);
    int find = 0;
for (int i = 0; i < array.Length; i++)
{
    if(countNumber == array[i])
    {
        find += 1;
        Console.WriteLine("Заданное число присутствует в массиве");
        break;
    }
}
if (find == 0)
{
    Console.WriteLine("Заданное число отсутствует в массиве");
}
