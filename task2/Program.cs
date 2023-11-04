//Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = new int[10];
for(int i = 0; i < array.Length; i++)
{
 array[i] = new Random().Next (1, 100);
 Console.Write(array[i] + " ");
}
Console.WriteLine();

int count = 0;
foreach (int number in array)
{
    if (number % 2 == 0)
    count++;
}

Console.WriteLine("Количество четных чисел: " + count);


    
