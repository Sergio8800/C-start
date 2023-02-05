int int_randomString = new Random().Next(100, 500);
Console.WriteLine("it is number complete: " + int_randomString);
string int_randomStringShot = Convert.ToString(int_randomString);
//Console.WriteLine(int_randomStringShot.GetType());
string xAx = int_randomStringShot.Substring(1, int_randomStringShot.Length - 2);
Console.WriteLine("numbers is trim: " + xAx + " - type is - " + xAx.GetType());
// **solution through math**
int numb1 = int_randomString / 10;
int numb2 = numb1 % 10;
Console.WriteLine($"Solution throuth math: number without midle pate is {numb2}");
//** second **
int stringLongNumber = new Random().Next(1, 50000);
Console.WriteLine("your inpun number: " + stringLongNumber);
string stringLongNumberStr = Convert.ToString(stringLongNumber);
Console.WriteLine(stringLongNumberStr);
char[] massivChares = stringLongNumberStr.ToCharArray();
//int s = int.Parse(Convert.ToString(massivChares[i])); // in one line
if (massivChares.Length > 2)
{
    char numberThree = massivChares[2];
    string numberThreeStr = Convert.ToString(numberThree);
    int numberThreeInt = Convert.ToInt32(numberThreeStr);
    Console.WriteLine(numberThreeInt + $" - it is three number in {stringLongNumber}" + " -type is int");
}
else
{
    Console.WriteLine("Number is shots");

}

//** solution through math **
Console.WriteLine("**solution througt math**");
int numNeeded = 0;
Console.WriteLine($"Starting process... number is {stringLongNumber}");
if (stringLongNumber>999)
{
    while (stringLongNumber > 999)
    {
        int numOne = stringLongNumber / 10;
        stringLongNumber = numOne;
        numNeeded = stringLongNumber % 10;
        Console.WriteLine("not yet, number is " + stringLongNumber + " on this step");
   }
    Console.WriteLine($"number three is {numNeeded}");
}
else if (stringLongNumber < 100)
{
    Console.WriteLine("Number three is't exists");
}
//** Number three **
Console.WriteLine("input number 1-7: ");
string dayOfWeekStr = Console.ReadLine();
int dayOfWeek = int.Parse(dayOfWeekStr);
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

if (dayOfWeek < 6)
{
    Console.WriteLine($"It is work day: {dict[dayOfWeek]}");
}
else if (dayOfWeek == 7 | dayOfWeek == 6)
{
    Console.WriteLine($"It is hollyday: {dict[dayOfWeek]}");
}
else if (dayOfWeek > 7)
{
    Console.WriteLine($"You entered a number outsize 1-7 range it is numb: {dayOfWeek}");
}
