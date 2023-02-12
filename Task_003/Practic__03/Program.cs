
void TwooNumber(double A, double B)
{
    double result = Math.Pow(A, B);
    Console.WriteLine($" {A} to the power {B} = {result}");
    
}
TwooNumber(2, 3);
// next-------------------
void SummaDigit(int Number)
{
    int summa = 0;
    while (Number > 0)
    {
        summa = summa + Number % 10;
        Number= Number / 10;
    }
    Console.WriteLine($"Summa digits of number is {summa}");
}
SummaDigit(22);
void MassivNumb(int Number)
{
    int[] mass = new int[Number];
    Console.WriteLine($"Array of {Number} element: ");
    while (Number > 0)
    {
        int x = new Random().Next(10,20);
        mass[Number-1] = x;
        Console.Write(mass[Number-1] + " ");
        Number--;
    }
}
MassivNumb(8);