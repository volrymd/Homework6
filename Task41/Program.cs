// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.WriteLine("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine()!);
int[] array = new int[m]; 
int count = 0;
for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine ("Введите число: ");
        array [i] = int.Parse (Console.ReadLine()!);
        if (array[i]>0) count+=1;     
    }
Console.WriteLine($"Количество чисел больше 0: {count}");
