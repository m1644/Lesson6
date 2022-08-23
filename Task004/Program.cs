// 

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

int [] CoppyArray(int[] arr)
{
    int[] newArr = new int [arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

int[] array = CreateArray(10, 1, 100);
Console.WriteLine();
int[] newArray = CoppyArray(array);
PrintArray(array);
PrintArray(newArray);
array[0] = 1;
PrintArray(array);
PrintArray(newArray);
