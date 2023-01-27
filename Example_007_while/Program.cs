// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;

Console.WriteLine("Hello, World!");
Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");
int xa = 1;
int ya = 1;
int xb = 2; 
int yb = 20;
int xc = 40;
int yc  = 40;
int x = xa;
int y = ya;
int cout = 0;
while (cout < 1000) 
{ 
    int w = new Random().Next(0, 3);
    if (w == 0)
    {
        x = (x + xa) / 2;

        y = (y + ya) / 2;  

    }
    if (w == 1)
    {
        x = (x + xb) / 2;

        y = (y + yb) / 2;

    }
    if (w == 2)
    {
        x = (x + xc) / 2;

        y = (y + yc) / 2;

    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    cout = cout + 1;

}





