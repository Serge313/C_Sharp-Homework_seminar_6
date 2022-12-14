TestingCountNumbersGreaterThanZero();
int sizeOfArray = GetNumber("Enter amount of numbers ");
int[] array = new int [sizeOfArray];
FillArray(array);
PrintArray(array);
int count = CountNumbersGreaterThanZero(array);
Console.Write($" -> {count}");


void TestingCountNumbersGreaterThanZero()
{
    Console.WriteLine("Testing of the \"CountNumbersGreaterThanZero\" method has been launched... ");
    int[] testArray = {0, 7, 8, -2, -2};
    int expected = 2;
    int actual = CountNumbersGreaterThanZero(testArray);
    bool isEqual = expected == actual;
    if (isEqual)
    {
        Console.WriteLine("Test completed successfully!");
    }
    else
    {
        Console.WriteLine("Error! Need to fix the method!");
    }
    Console.WriteLine();
}


int CountNumbersGreaterThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
}


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetNumber($"Enter the number at index {i} ");
    }
}


int GetNumber(string message)
{
    Console.Write(message);
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);
    if (isParsed)
    {
        return number;
    }
    else
    {
        Console.WriteLine("Invalid value entered!");
        return -1;
    }
}