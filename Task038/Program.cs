Console.Clear();

Console.Write("Определение разницы между максимальным и минимальным элементами в массиве -> Введите элементы массива через пробел: ");
String elements = Console.ReadLine();

int[] array = GetArrayFromString(elements);

Console.WriteLine($"[{String.Join(", ", array)}]");

Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {maxAndMinElement(array)} ");

int[] GetArrayFromString(string stringArray)
{
    string[] numbers = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        result[i] = int.Parse(numbers[i]);
    }
    return result;
}

int maxAndMinElement(int[] array)
{
    int sum = 0;
    int max = 0;
    int min = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[max])
        {
            max = i;
        }
        else
        {
            if (array[i] < array[min])
            {
                min = i;
            }
        }
    }
    sum = array[max] - array[min];
    return sum;
}