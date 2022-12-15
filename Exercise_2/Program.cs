double b1 = GetNumber("Enter value of \"b1\" ");
double k1 = GetNumber("Enter value of \"k1\" ");
double b2 = GetNumber("Enter value of \"b2\" ");
double k2 = GetNumber("Enter value of \"k2\" ");
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
        double FindX(double b1, double k1, double b2, double k2)
        {
            double x = (b2 - b1) / (k1 - k2);
            return (x);
        }
        double x = FindX(b1, k1, b2, k2);

        
        double FindY(double k1, double b1, double x)
        {
            double y = k1 * x + b1;
            return(y);
        }
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