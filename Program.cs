/*
//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void ShowNumbers(int number)
{
      Console.Write(number + " ");
    if (number > 1) ShowNumbers(number -1);
//    Console.Write(number + " ");
}
ShowNumbers(5);

//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int SumDigits(int num)
{
    if (num < 0) num *= -1;
    if (num > 0) return SumDigits(num/10) + num % 10;
    else return 0;
}
int res = SumDigits(157);
Console.WriteLine(res);

//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// N < M, N = M, M < N
void Show2Numbers(int m, int n)
{
//      Console.Write(n + " ");
    if (n > m) Show2Numbers(m,n -1);
      Console.Write(n + " ");
}
Show2Numbers(5,10);
*/
//Напишите программу, которая на вход принимает два числа A и B,
//и возводит число А в целую степень B с помощью рекурсии.

double FindPower(int a, int b)
{
    if(b>0) return FindPower(a,b-1)*a;
    return 1.0;
}
double result = FindPower(2,5);
Console.WriteLine(result);
