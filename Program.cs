// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
//https://github.com/profimars/C-Seminar5Task38
void FillArray(int[] AA)
{
    Random rnd = new Random();
    for (int i = 0; i < AA.Length; i++)
        AA[i] = rnd.Next(0, 100);
}
void PrintArray(int[] AA)
{
    foreach (int element in AA)
    {
        Console.Write($"{element}; ");
    }
    Console.WriteLine();
}
int DifferenceMaxMin(int[] AA)
{
    int max = AA[0];
    int min = AA[0];
    int diff = 0;
    for (int i = 0; i < AA.Length; i++)
    {
        if (AA[i] > max)
            max = AA[i];
        else
            if (AA[i] < min)
            min = AA[i];
    }
    return diff = max - min;
}
Console.WriteLine("Введите количество элементов в массиве а");
int a = Convert.ToInt32(Console.ReadLine());
int[] AA = new int[a];
FillArray(AA);
PrintArray(AA);
int rez = DifferenceMaxMin(AA);
Console.WriteLine("Разницу между максимальным и минимальным элементов массива = " + rez);
