//Задача 2: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22



Console.WriteLine("Enter num:");
string strNum1 = Console.ReadLine();

Console.WriteLine("Enter num:");
string strNum2 = Console.ReadLine();

Console.WriteLine("Enter num:");
string strNum3 = Console.ReadLine();


int num1 = int.Parse(strNum1);
int num2 = int.Parse(strNum2);
int num3 = int.Parse(strNum3);

int max = num1;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
   
Console.WriteLine($"{max} максимальное из трех");