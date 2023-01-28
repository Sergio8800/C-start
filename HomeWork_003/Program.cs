Console.Write("Введите число и нажмите клавишу Enter: ");
string str1 = Console.ReadLine();
int str1_int = Convert.ToInt32(str1);
if (str1_int%2 == 0)
{
    Console.Write("число: " + str1_int.ToString());
    Console.WriteLine(" чётное");
}
else
{
    Console.Write("число: " + str1_int.ToString());
    Console.WriteLine(" не чётное");
}