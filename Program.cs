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