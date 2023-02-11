
int[] a = { 3,6};
int[] b = { 2,1};
int x = b[0] - a[0];
int y = b[1] - a[1];  
double distantce = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y,2));
Console.WriteLine(Math.Round(distantce,2));
// polindrom
Console.WriteLine("write the fife digit number");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / 1000;
int num2 = num % 100;
int num1_a = num1 / 10;
int num1_b = num1 % 10;
int num2_a = num2 / 10;
int num2_b = num2 % 10;
if (num1_a == num2_b & num1_b == num2_a)
{
    Console.WriteLine("it is polinom");
}
else
{
    Console.WriteLine("NOT");
}
Console.WriteLine("part thirst: "+num1 + " part second: " + num2);

// 3D space
Console.WriteLine("input x,y,z point A: ");
int Ax = Convert.ToInt32(Console.ReadLine());
int Ay = Convert.ToInt32(Console.ReadLine());
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input x,y,z point B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
int By = Convert.ToInt32(Console.ReadLine());
int Bz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Distanc is: " + Math.Sqrt(Math.Pow((Bx-Ax),2)+Math.Pow((By-Ay),2)+
    Math.Pow((Bz-Az),2)));
// Cub
Console.WriteLine("input the number: ");
int cubNum = Convert.ToInt32(Console.ReadLine());
while (cubNum > 1)
{
    Console.WriteLine($" number: {cubNum} in cub: {Math.Pow(cubNum, 3)}");
    cubNum--;
}
