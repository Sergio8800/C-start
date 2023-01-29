var dict = new Dictionary<int, string>()
{
    [1] = "Понельник",
    [2] = "Вторник",
    [3] = "Среда",
    [4] = "Четверг",
    [5] = "Пятница",
    [6] = "Суббота",
    [7] = "Воскресенье",
};
Console.WriteLine("inpun number 1-7: ");
string x = Console.ReadLine();
int x_int = Convert.ToInt32(x);
Console.WriteLine(dict[x_int]);