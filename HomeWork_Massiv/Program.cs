//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

void print() { Console.WriteLine("---------Exercise Next---------");}
void printList(List<int> massiv) { foreach (int j in massiv) { Console.Write($"{j} "); } }
int[] GenMassiv(int amout, int rangStart, int rangFinish)
{
    int[] massiv = new int[amout];
    for (int i = 0; i < massiv.Length; i++)
    { massiv[i] = new Random().Next(rangStart, rangFinish); }
    return massiv;
}
void AmoutEvenNumbers(int[] arrayData)
{
    int[] dataArray = arrayData;
    int countEven = 0;
    List<int> quantityEven = new List<int>();
    foreach (int i in arrayData) 
    {
        Console.Write($"{i} "); 
        if (i%2 ==0) { countEven++; quantityEven.Add(i); }
    }
    Console.WriteLine("");
    Console.WriteLine($"quantity the numbers even = {countEven} It is:");
    //foreach (int j in quantityEven) { Console.Write($"{j} "); }
    printList(quantityEven);
    Console.WriteLine();
}
print();
AmoutEvenNumbers(GenMassiv(12, 100, 330));

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

void AmoutSummaNumbers(int[] arrayData)
{
    int[] dataArray = arrayData;
    int countEvenSumma = 0;
    List<int> quantityEven = new List<int>();
    foreach (int i in arrayData)
    {
        Console.Write($"{i} ");
        if (i % 2 != 0) { countEvenSumma+=i; quantityEven.Add(i); }
    }
    Console.WriteLine("");
    Console.WriteLine($"Summa the numbers not even = {countEvenSumma} consiste of these:");
    //foreach (int j in quantityEven) { Console.Write($"{j} "); }
    printList(quantityEven);
}
print();
AmoutSummaNumbers(GenMassiv(5, 10, 20));
//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
void Difference(int[] arrayData)
{
    int[] dataArray = arrayData;
    int maxNumber = dataArray[0];
    int minNumber = dataArray[0];
    foreach (int i in dataArray)
    {
        Console.Write($"{i} ");
        if (maxNumber < i) { maxNumber = i; }
        if (minNumber > i) { minNumber = i; }
    }
    int diff = maxNumber- minNumber;

    Console.WriteLine($"minimum = {minNumber} maximum = {maxNumber} diffirece = {diff}");
}
print();
Difference(GenMassiv(7, 10, 20));