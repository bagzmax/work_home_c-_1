﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

int max = numberA;
int min = numberB;

if (max == min)
{
    System.Console.WriteLine("Равные числа");
}
else
{ if (max < min)
   { max = numberB;
     min = numberA;
   }  
     System.Console.WriteLine("Максимальное число = " + max);
     System.Console.Write("Минимальное число = " + min);
}




 
