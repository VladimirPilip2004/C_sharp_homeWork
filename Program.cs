//ДЗ Владимира Пилипенко
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    {
        Console.WriteLine($"Максимальное число {num1}");
        Console.WriteLine($"Минимальное число {num2}");
    }
    else if (num1 < num2)
            {
                Console.WriteLine($"Максимальное число {num2}");
                Console.WriteLine($"Минимальное число {num1}");
            }
            else
            {
                Console.WriteLine("Оба числа равны");
            }
Console.Write("Максимальное число: ");
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2>num1)
    {
        max = num2;
    }
if (num3>max)
    {
        max = num3;
    }
Console.WriteLine($"Максимальное число: {max} ");
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
    {
        Console.WriteLine($"{num} - чётное число ");
    }
    else
    {
        Console.WriteLine($"{num} - нечётное число ");
    }
*/   
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Введите любое целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int evenNumber = 1, current = 1;

while (evenNumber <= N)
{
	if (evenNumber % 2 == 0)
	{
        Console.Write(evenNumber + " ");
		current++;
	}
	evenNumber++;
}
*/