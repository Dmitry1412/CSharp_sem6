/*
Задача 39: Напишите программу,
которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
*/
var arr = GenerateArray(11);
PrintArray(arr);
ReverseArray(arr);
System.Console.WriteLine();
PrintArray(arr);

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = tmp;
    }
}

int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}

void PrintArray(int[] array)
{
    foreach (int i in array) // перебирает непосредственно значение элементов массива
    {
        Console.Write($"{i} ");
    }
}