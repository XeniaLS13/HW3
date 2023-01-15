double GetDistance(double a1, double a2, double b1, double b2, double c1, double c2)
{
    return Math.Sqrt(Math.Pow(a1 - a2,2)
                    + Math.Pow(b1 - b2,2)
                    + Math.Pow(c1 - c2,2));
}

double GetValue(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine()); 
}

double a1 = GetValue("a1 = ");
double a2 = GetValue("a2 = ");
double b1 = GetValue("b1 = ");
double b2 = GetValue("b2 = ");
double c1 = GetValue("c1 = ");
double c2 = GetValue("c2 = ");
double distance = GetDistance(a1, a2, b1, b2, c1, c2);
System.Console.WriteLine(distance);