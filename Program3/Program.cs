//Написати програму-калькулятор.

//Користувач вводить два числа та вибирає арифметичну дію.

//Вивести на екран результат.

using System;

Console.WriteLine("Enter two numbers.");
Console.WriteLine("The first number:");
var n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The second number:");
var n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Choose an arithmetic operation (/,*,-,+):");
string action = Console.ReadLine();
//string action = operation.ToString();
if (action == "+")
{
    int a1 = n1 + n2;
    Console.WriteLine($"Result: {a1}");
}

else if (action == "-")
{
    int a2 = n1 - n2;
    Console.WriteLine($"Result: {a2}");
}

else if (action == "*")
{
    int a3 = n1 * n2;
    Console.WriteLine($"Result: {a3}");
}
else if (action == "/")
{
    int a4 = n1 / n2;
    Console.WriteLine($"Result: {a4}");
}

else
        {
    Console.WriteLine("Error");
}