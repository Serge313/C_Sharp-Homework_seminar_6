TestingFindXAndFindY();
double b1 = GetNumber("Enter value of \"b1\" ");
double k1 = GetNumber("Enter value of \"k1\" ");
double b2 = GetNumber("Enter value of \"b2\" ");
double k2 = GetNumber("Enter value of \"k2\" ");


void TestingFindXAndFindY()
{
    Console.WriteLine("Testing of \"FindX\" and \"FindY\" methods has been launched... ");
    double testB1 = 2;
    double testK1 = 5;
    double testB2 = 4;
    double testK2 = 9;
    double expectedX = -0.5;
    double actualX = FindX(testB1, testK1, testB2, testK2);
    double expectedY = -0.5;
    double actualY = FindY(testK1, testB1, actualX);
    bool isEqual = expectedX == actualX && expectedY == actualY;
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


double FindX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return (x);
}


double FindY(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return(y);
}


IntersectOrNot(b1, k1, b2, k2);


void IntersectOrNot(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Lines match!");
        return;
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Lines are parallel!");
        return;
    }
    else
    {
        double x = FindX(b1, k1, b2, k2);
        double y = FindY(k1, b1, x);
        Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x};{y})");
    }
    
}

double GetNumber(string message)
{
    Console.Write(message);
    bool isParsed = double.TryParse(Console.ReadLine(), out double number);
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