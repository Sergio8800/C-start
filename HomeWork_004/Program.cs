using System.Diagnostics.Metrics;

Console.Write("Введите число:");
string str1 = Console.ReadLine();
int str1_int = Convert.ToInt32(str1);
int count = 2;
while(count <= str1_int)
{
    Console.Write(count.ToString() + ", ");
    count = count + 2; 
}