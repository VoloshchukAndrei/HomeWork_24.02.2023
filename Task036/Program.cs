Console.Clear();

Console.Write("Определение суммы элементов в массиве, стоящих на нечётных позициях  -> Укажите длину массива: ");
int number = int.Parse(Console.ReadLine()!);

int[] array = RandomArray(number);

Console.WriteLine($"[{String.Join(", ", array)}]");

Console.WriteLine($"Сумма элементов в массиве, стоящих на нечётных позициях = {sumOverOddIndices(number)} ");

int[] RandomArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-1000, 1000);
    }
    return result;
}

int sumOverOddIndices(int size)
{
    int sum = 0;
    for (int i = 1; i < size; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}