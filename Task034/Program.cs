Console.Clear();

Console.Write("Определение количества чётных трёхзначных чисел в массиве -> Укажите длину массива: ");
int number = int.Parse(Console.ReadLine()!);

int[] array = threeDigitArray(number);

Console.WriteLine($"[{String.Join(", ", array)}]");

Console.WriteLine($"Количество чётных чисел в массиве = {GetCountElements(number)} ");

int[] threeDigitArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

int GetCountElements(int size)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if((array[i] % 2) == 0) 
        {
            count++;
        }
    }
    return count;
}