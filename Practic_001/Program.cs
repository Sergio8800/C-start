Console.WriteLine("input number 1: ");
string x1 = Console.ReadLine();
int x1_int = Convert.ToInt32(x1);
Console.WriteLine("input number 2: ");
string x2 = Console.ReadLine();
int x2_int = Convert.ToInt32(x2);
if (x1_int * x1_int == x2_int)
    Console.WriteLine($"number {x2_int} is square number {x1_int}");
else if (x2_int * x2_int == x1_int)
    Console.WriteLine($"number {x1_int} is square number {x2_int}");
else Console.WriteLine("squarу does not exist");
