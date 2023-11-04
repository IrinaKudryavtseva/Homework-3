// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[10];
for(int i = 0; i < array.Length; i++)
{
  Random rnd = new Random();
  array[i] = Math.Round((0.01 + rnd.NextDouble() * (0.01 + 100.00)),2);
  Console.Write(array[i] + " ");
}
Console.WriteLine();
 double min = array[0];
 double max = array[0];

foreach (double number in array)
    {
      if (number < min)
      min = number;
            

      if (number > max)
      max = number;
           
    }
Console.WriteLine("Минимальный элемент массива:" + min);
Console.WriteLine("Максимальный элемент массива:" + max);  

double difference = max - min;

Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
    


   
   

   
   
   
   

   
   
   

   

   
   
