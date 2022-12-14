TestingCountNumbersInString();
TestingParseStringToArray();
TestingCountNumbersGreaterThanZero();
Console.Write("Enter numbers separated by commas: ");
string input = Console.ReadLine();
int[] numbers = ParseStringToArray(input);
int amountNumbersGreaterThenZero = CountNumbersGreaterThanZero(numbers);
PrintNumbers(numbers);
Console.WriteLine($" -> {amountNumbersGreaterThenZero}");


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


void TestingParseStringToArray()
{
    Console.WriteLine("Testing of the \"ParseStringToArray\" method has been launched... ");
    string testString = "1,-7,567,89,223";
    int[] expected = {1,-7,567,89,223};
    int[] actual = ParseStringToArray(testString);
    if (expected.SequenceEqual(actual))
    {
        Console.WriteLine("Test completed successfully!");
    }
    else
    {
        Console.WriteLine("Error! Need to fix the method!");
    }
    Console.WriteLine();
}


void TestingCountNumbersInString()
{
    Console.WriteLine("Testing of the \"CountNumbersInString\" method has been launched... ");
    string testString = "0,7,8,-2,-2";
    int expected = 5;
    int actual = CountNumbersInString(testString);
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


void PrintNumbers(int[] array)
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


int[] ParseStringToArray(string input)
{
    int sizeOfArray = CountNumbersInString(input);
    int[] numbers = new int [sizeOfArray];
    int indexNumber = 0;
    string numbersWithoutCommas = string.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ',')
        {
            numbersWithoutCommas += input[i];
        }
        else
        {
            numbers[indexNumber] = Convert.ToInt32(numbersWithoutCommas);
            indexNumber++;
            numbersWithoutCommas = string.Empty;
        }
    }
    if (input[input.Length - 1] != ',')
    {
        numbers[indexNumber] = Convert.ToInt32(numbersWithoutCommas);
    }
    return numbers;
}


int CountNumbersInString(string input)
{
    int count = 1;
    if (input[input.Length - 1] == ',')
    {
        count = 0;
    }
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }
    return count;
}