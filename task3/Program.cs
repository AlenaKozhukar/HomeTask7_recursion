// Задача 3: Задайте произвольный массив. Выведите его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] array = {25, 1, 14, 7, 35, 0};

void PrintArrayReverse(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }
    Console.Write(array[index] + " ");
    PrintArrayReverse(array, index - 1);
}

PrintArrayReverse(array, array.Length - 1);
