
using System.Security.Cryptography;

string stopProces = "s";
int counter = 0;
while (stopProces != "p")
{
    Console.Write("Введите число и нажмите клавишу Enter или p для прекращения: ");
    stopProces = Console.ReadLine();
        if (stopProces == "p") { Console.WriteLine("Thank you. You finished"); }
        else 
        {
            int plusMinus = Convert.ToInt32(stopProces);
            if (plusMinus > 0) 
            { counter++; }
            Console.WriteLine();
            Console.WriteLine($"The quantity of Positiv numbers is: {counter}");
    }
        
}
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double x = 0; int b1 = 2; int b2 = 4;
double y = 0; int k1 = 5; int k2 = 9;
int[] massBandK = new int[4];
for (int i = 0; i < 4; i++)
{
    Console.Write("Введите числo ");
    massBandK[i] = Convert.ToInt32(Console.ReadLine());
}
b1 = massBandK[0]; k1 = massBandK[1]; b2 = massBandK[2]; k2 = massBandK[3];


y  = (b1- k1*b2 / k2 ) /(1-k1/k2);
x = (y - b2) / k2;
Console.WriteLine($" y= { y} ,  x= {x}");
