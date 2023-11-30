// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"b

System.Console.WriteLine("Введите число");
int nam = Convert.ToInt32(Console.ReadLine());

int FirstEnd = 1;

void Print(int starat ,int end)
{
    if(starat >=end) 
    {Console.Write($"{starat}\t");
    Print(starat-1 , end);
    }

}
Print(nam,FirstEnd);

