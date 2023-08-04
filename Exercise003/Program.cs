//Задача 3: Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Enter num:");
string strNum = Console.ReadLine();

int num = int.Parse(strNum);

int remDiv = num % 2;

if (remDiv == 0)
{
    Console.WriteLine($"{num} чётное");
}
else
{
    Console.WriteLine($"{num} нечётное");
}
