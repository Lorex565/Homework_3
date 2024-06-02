//Користувач із клавіатури вводить 5 оцінок студента.

//Визначити, чи допущено студента до іспиту.

//Студент отримує допуск, якщо його середній бал 4 бали та вище.

Console.WriteLine("Enter 5 ratings.");
Console.WriteLine("Enter rating number 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter rating number 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter rating number 3: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter rating number 4: ");
int n4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter rating number 5: ");
int n5 = Convert.ToInt32(Console.ReadLine());

int number = (n1 + n2 + n3 + n4 + n5) % 5;

if (number >= 4)
{
    Console.WriteLine("The student is admitted to the exam");
}

else
{
    Console.WriteLine("The student was not admitted to the exam.");
}


