
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3, 4, 1, 77, 65] => 77 - 1 = 76

double GetMax(double[] numbers)
{
    double max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}

double GetMin(double[] numbers)
{
    double min = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;
}

double[] numbers = { 3, 4, 1, 77, 65 };
double min = GetMin(numbers);
double max = GetMax(numbers);
double difference = max - min;
Console.WriteLine($" Разница равна: {difference}");
