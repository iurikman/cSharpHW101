
// Сортировка выбором

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array [j] = temp;
            }
        }
    }
}

int[] array = {0, 7, 5, 4, 4, 2, 9, 0 ,9};

void ShowArray(int[] array)
{
    Console.WriteLine($"[{String.Join(',', array)}]");
}


ShowArray(array);
SortArray(array);
ShowArray(array);