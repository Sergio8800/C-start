//64: Задайте значение N. Напишите программу, которая выведет все
//натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string RequrNum(int a)
{
	string str = String.Empty;
	//int b = 1;
	if (a==1)
	{
		return Convert.ToString(a);
	}
	str += $"{Convert.ToString(a)} ";
	return str + RequrNum(a - 1);
}
Console.WriteLine(RequrNum(15));
//66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 4; N = 8. -> 30

int SummaRequr(int a,int b)
{
	if (a==b)
	{
		return a;
	}
	return b + SummaRequr(a, b - 1);
}
Console.WriteLine($"Summa 4-8 = {SummaRequr(4,8)}");
//68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29

int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n, m);

}

Console.WriteLine("Ancerman 3x2 = " + A(3, 2));
//функция ack(n, m)
//   пока n ≠ 0
//     если m = 0
  //     m:= 1
    // иначе
      // m:= ack(n, m - 1)
     //n:= n - 1
   //вернуть m + 1

 
