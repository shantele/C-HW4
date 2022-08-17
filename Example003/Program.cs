// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void FillArray(int[] array)          // Метод для заполнения массива
{
    for (int i = 0; i < 8; i++)
    {

        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Введите 8 чисел последовательно: ");
int[] newArr = new int[8];
FillArray(newArr);
Console.WriteLine($"Массив: [ {String.Join("; ", newArr)} ]");