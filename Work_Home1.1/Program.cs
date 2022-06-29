//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

int max = numberA;
int min = numberB;

if (numberA == numberB)
{
    System.Console.WriteLine("Равные числа");
}
else { if (numberA > numberB)
{
    System.Console.WriteLine("max= " + max);
    System.Console.Write("min= " + min);
}
else
{
   System.Console.WriteLine("max= " + min);
   System.Console.Write("min= " + max);
}
}

 
