// Напишите программу, которая перевернет одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] CreateArray(int length, int min, int max) // Задать массив
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array) // Вывод массива на печать
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array [i]} ");
    Console.WriteLine();
}

void ReverseArray(int[] arr) // Перевернуть массив
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = temp;
    }
}

int[] arr = CreateArray(10, -5, 10);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);
