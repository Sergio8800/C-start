
//int int_random = new Random().Next(10, 100);
//Console.WriteLine(int_random);
//int int_randomShot= int_random/10;
//Console.WriteLine(int_randomShot);
int int_randomString = new Random().Next(100, 500);
Console.WriteLine("it is number complete: " + int_randomString);
string int_randomStringShot = Convert.ToString(int_randomString);
//Console.WriteLine(int_randomStringShot.GetType());
string x_x = int_randomStringShot.Remove(1, int_randomStringShot.Length- 2);
string xAx = int_randomStringShot.Substring(1, int_randomStringShot.Length - 2);
Console.WriteLine("it is string:" + x_x + " Without midle number: " + xAx);
int x2 = int.Parse(x_x);
//int x = Convert.ToInt32(int_randomStringShot);
//Console.WriteLine(x);
Console.WriteLine("numbers is trim: " + x2 +" - type is - "+ x2.GetType());
int stringLongNumber = new Random().Next(900000, 5000000);
Console.WriteLine("your inpun number: " + stringLongNumber);
string stringLongNumberStr = Convert.ToString(stringLongNumber);
Console.WriteLine(stringLongNumberStr);
char[] massivChares = stringLongNumberStr.ToCharArray();
//int s = int.Parse(Convert.ToString(massivChares[i])); // in one line
char numberThree = massivChares[2];
string numberThreeStr = Convert.ToString(numberThree);
int numberThreeInt = Convert.ToInt32(numberThreeStr);
Console.WriteLine(numberThreeInt + $" - it is three number in {stringLongNumber}" + " -type is int");