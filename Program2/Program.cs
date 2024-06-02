//Користувач вводить із клавіатури число.

//Якщо воно парне, помножити його на три, інакше поділити на два.

//Результат вивести на екран.

Console.WriteLine("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    int result = number * 3;
    Console.WriteLine($"{result}");
}

else
{
    int result = number / 2;
    Console.WriteLine($"{result}");
}

