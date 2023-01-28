Console.Write("Введите первое число и нажмите клавишу Enter: ");
string str1 = Console.ReadLine();
int str1_int = Convert.ToInt32(str1);
Console.Write("Введите второе число и нажмите клавишу Enter: ");
string str2 = Console.ReadLine();
int str2_int = Convert.ToInt32(str2);
Console.Write("Введите третье число и нажмите клавишу Enter: ");
string str3 = Console.ReadLine();
int str3_int = Convert.ToInt32(str3);
int max = str1_int;
if (str2_int > max)
{
    max = str2_int;
}
if (str3_int > max)
{
    max = str3_int;
}
Console.WriteLine("Maximum: " + max.ToString());
