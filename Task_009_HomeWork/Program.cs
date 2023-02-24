int[,] masss = {{5, 2, 3 },
        { 4, 1, 6 },
        { 7, 8, 9 } };
void PrintM(int[,] masss)
{
    //Console.WriteLine("------print array------");
    for (int i = 0; i < masss.GetLength(0); i++)
    {
        for (int j = 0; j < masss.GetLength(1); j++)
        {
            Console.Write($" {masss[i, j]} ");
        }
        Console.WriteLine();
    }
}
void PS(string str= "Separator between parts") { Console.WriteLine($"--------{str}-----"); }
void P() { Console.WriteLine("--------Next Task-----"); }

// 59:

int[,] DelMin(int[,] arr)
{
    int[,] mass = arr;
    int minimum = mass[0, 0]; int indexI = 0; int indexJ = 0;

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass[i, j] < minimum)
            {
                minimum = mass[i, j];
                indexI = i;
                indexJ = j;
            }
        }
    }
    //Console.WriteLine(minimum);
    int[,] tmp = new int[mass.GetLength(0) - 1, mass.GetLength(1) - 1];
    //int[,] tmp = new int[mass.GetLength(0), mass.GetLength(1)];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        if (i < indexI)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                if (j < indexJ)
                {
                    tmp[i, j] = mass[i, j];
                }
                else if (j > indexJ)
                {
                    tmp[i, j - 1] = mass[i, j];
                }
            }
        }
        else if (i > indexI)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                if (j < indexJ)
                {
                    tmp[i - 1, j] = mass[i, j];
                }
                else if (j > indexJ)
                {
                    tmp[i - 1, j - 1] = mass[i, j];
                }
            }
        }

    }

    return tmp;
}
PrintM(masss);
PS();
PrintM(DelMin(masss));
P();
//54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию
//элементы каждой строки двумерного массива.
int[,] CreatArr(int a, int b)
{
    int[,] arr = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            arr[i, j] = new Random().Next(0, 5);
        }
    }
    return arr;
}
int[,] OrderedArr(int[,] array)
{
    int[,] arr = array ;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int buffer = 0;
        for (int j = 0; j < arr.GetLength(1)-1; j++)
        {
            
            for (int k = j+1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > arr[i, j])
                {
                    buffer = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = buffer;
                                
                }
                             
            }
            
        }
        
    }
    return arr;
}
int[,] arrOrder = CreatArr(3, 5);
PrintM(arrOrder);
PS("Строки упорядоченные по убыванию");
PrintM(OrderedArr(arrOrder));
//56: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.
void MinimumOfLineArr(int[,] array)
{
    int[,] arr = array;
    int[] counter = new int[array.GetLength(0)];

    int min = 2500;
    int index = 0;
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int k = i;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            counter[k] = counter[k] + arr[i, j];
            
        }
    }
    for (int i = 0; i < counter.Length; i++)
    {
        Console.WriteLine($" {i} summ {counter[i]} ");
        if (counter[i] < min)
        {
            index = i;
            min = counter[i];
        }
    } Console.WriteLine($" Line index number {index} is Minimum - whith summa {min} ");
    
}
P();
MinimumOfLineArr(arrOrder);
//58: Задайте две матрицы. Напишите программу,
//которая будет находить произведение двух матриц.
int[,] matrixOne = CreatArr(3, 2);
int[,] matrixTwo = CreatArr(2, 3);
int[,] MultiplicationMatrix(int[,] arr1, int[,] arr2)
{
    int[,] matrixOne = arr1;
    int[,] matrixTwo = arr2;
    int[,] result = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    if (matrixOne.GetLength(0) != matrixTwo.GetLength(1)) { Console.WriteLine("Unposible!"); return matrixOne; }
    
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int k = 0; k < matrixOne.GetLength(0); k++)
        {
            int[] temp = new int[matrixTwo.GetLength(1)];
            for (int j = 0; j < matrixOne.GetLength(1); j++)
            {
                temp[k] = matrixOne[i, j] * matrixTwo[j, k];
                // c11 = a11 · b11 + a12 · b21 
                //c12 = a11 · b12 + a12 · b22
                //Console.Write($" {temp[k]} ");
                result[i, k] = result[i, k] + temp[k];
            } //Console.WriteLine();
            //for (int s = 0; s < temp.Length; s++){ result[i, k] += temp[s];}
        }
        

    } return result;
}
P();
PS("Первая матрица");
PrintM(matrixOne);
PS("Вторая матрица");
PrintM(matrixTwo);
PS("Произведение");
PrintM(MultiplicationMatrix(matrixOne, matrixTwo));
//60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2



int[] CreatUnicumeArray(int size)
{
    int[] masive = new int[size];
    //Console.WriteLine(masive[9]);
    int k = 0;
    int flag = 0;
    while (masive[size-1]==0)
    {    
        int m = new Random().Next(1, 21);
        for (int i = 0; i < masive.Length; i++)
        {
            if (masive[i] == m)
            {

                break;
            }
            flag = 1;
        }
        if (flag == 1)
        {
            masive[k] = m;
            //Console.Write($"{masive[k]} ");
            k++;
        }   
    }
    return masive;
}

Console.WriteLine("Вывод массива с уникальными данными");
int[,,] CreatArr3D(int a, int b, int c)
{
    int[,,] arr = new int[a, b, c];
    int[] temp = CreatUnicumeArray(a * b * c);
    int counterZ = 0;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                //arr[i, j, k] = new Random().Next(1, 11);
                // проверка на уникальность.
                arr[i, j, k] = temp[counterZ];
                counterZ++;
            }

        }
    }
    return arr;
}
int[,,] x = CreatArr3D(2, 2, 2);
P();

void PrintM3D(int[,,] masss)
{

    for (int i = 0; i < masss.GetLength(0); i++)
    {
        for (int j = 0; j < masss.GetLength(1); j++)
        {
            for (int k = 0; k < masss.GetLength(2); k++)
            {
                Console.Write($" {masss[i, j, k]} idex: ({i},{j},{k})");
            }

        }
        Console.WriteLine();
    }
}
PrintM3D(x);

//62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
int[] tempEx= {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16};
int[,] arrSpiral = new int[4,4];
int kkk = 0;
int iii = 0;
int tempAdaptor = 0;
for (int j = 0; j < arrSpiral.GetLength(0); j++)
{
    arrSpiral[iii, j] = tempEx[kkk];
    kkk++; tempAdaptor = j;
}
for (int i = iii+1; i < arrSpiral.GetLength(1); i++)
{
    arrSpiral[i, tempAdaptor] = tempEx[kkk];
    kkk++; iii = i;
}
for (int j = tempAdaptor - 1; j >= 0; j--)
{
    arrSpiral[iii, j] = tempEx[kkk];
    kkk++; tempAdaptor = j;
}
for (int i = iii - 1; i > 0; i--)
{
    arrSpiral[i, tempAdaptor] = tempEx[kkk];
    kkk++; iii = i;
}
for (int j = tempAdaptor + 1; j < arrSpiral.GetLength(0) - 1; j++)
{
    arrSpiral[iii, j] = tempEx[kkk];
    kkk++; tempAdaptor = j;
}
for (int j = tempAdaptor; j >0 ; j--)
{
    arrSpiral[iii+1, j] = tempEx[kkk];
    kkk++; tempAdaptor = j;
}

P();
PrintM(arrSpiral);