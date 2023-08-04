//Задача : Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


Console.WriteLine("Enter num:");
string strNum1 = Console.ReadLine();

Console.WriteLine("Enter num:");
string strNum2 = Console.ReadLine();

int num1 = int.Parse(strNum1);
int num2 = int.Parse(strNum2);

int min = 0;
int max = num1;
if (num1 > num2) 
   {
       max = num1; 
       min = num2;
   }
 else
   {
       max = num2; 
       min = num1;
   }


Console.WriteLine($"{max} больше {min} ");