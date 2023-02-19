int[,] CreatArr(int a,int b)
{
	int[,] arr = new int[a,b];
	for (int i = 0; i < a; i++)
	{
		for (int j = 0; j < b; j++)
		{
			arr[i, j] = new Random().Next(0, 50);
		}
	}
	return arr;
}

void PrintArr(int[,] mass)
{
	
	for (int i = 0; i < mass.GetLength(0); i++)
	{
		for (int j = 0; j < mass.GetLength(1); j++)
		{
			Console.Write($"{mass[i, j]} ");
        }
	 Console.WriteLine();
	}
}

	int[,] DataMass = CreatArr(3, 5);
	PrintArr(DataMass);
Console.WriteLine("-------Next------");
//возвращает значение этого элемента

void NumberOfArr(int[,] mass, int a)
{
	int indexI = 0; int indexJ = 0;
	int flag = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if(mass[i, j] == a)
			{
				flag = 1;
				indexI = i; indexJ = j;
				Console.WriteLine($"exists number {a} in place index {indexI} & {indexJ}");
			}
        }
		

    }
	if (flag == 0) Console.WriteLine($"does not exist number: {a}");
}
NumberOfArr(DataMass, 15);
Console.WriteLine("-------Next------");
// Среднее арифметическое каждого столбца
void ArithmeticMean(int[,] mass)
{
	
	int Count = 0;
	Console.WriteLine("Arithemic mean of each column:");
    for (int i = 0; i < mass.GetLength(1); i++)
    {
        double ArithMean = 0;
        for (int j = 0; j < mass.GetLength(0); j++)
        {
			ArithMean += mass[j, i]; Count++;
        }
		Console.Write($"{Math.Round(ArithMean/Count,2)} ");

    }
    
}
ArithmeticMean(DataMass);