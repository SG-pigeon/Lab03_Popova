Console.WriteLine("Банковский счёт");

double balance = 1000;
Console.WriteLine($"Начальный баланс: {balance}");

balance += 500; //пополнение
System.Console.WriteLine($"После пополнения на 500: {balance}");

balance -= 200; //покупка
System.Console.WriteLine($"После покупки на 200: {balance}");

balance *= 1.05; //начисление 5%
System.Console.WriteLine($"После начисления 5%: {balance}");

balance /= 2; //разделили счёт пополам с партнёром
System.Console.WriteLine($"После деления пополам: {balance}");

System.Console.WriteLine();
System.Console.WriteLine("Постфикс vs префикс");

int lessonNumber = 1;
System.Console.WriteLine($"lessonNumber++  выводит: {lessonNumber++}");
System.Console.WriteLine($"После этого lessonNumber = {lessonNumber}");

int weekNumber = 1;
System.Console.WriteLine($"++weekNumber  выводит: {++weekNumber}");
System.Console.WriteLine($"После этого weekNumber = {weekNumber}");

System.Console.WriteLine();
System.Console.WriteLine("Практическая ловушка");

int attempts = 0;
System.Console.WriteLine($"Попытка №{++attempts}");
System.Console.WriteLine($"Попытка №{++attempts}");
System.Console.WriteLine($"Всего попыток: {attempts}");