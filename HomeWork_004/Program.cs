Console.Write("Введите число:");
string str1 = Console.ReadLine();
int str1_int = Convert.ToInt32(str1);
while(str1_int>1)
{
    if (str1_int%2==0)
    {
        Console.Write(", " + str1_int.ToString());
    }
   str1_int = str1_int - 1; 
}