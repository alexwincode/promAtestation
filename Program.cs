// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"b

// System.Console.WriteLine("Введите число");
// int nam = Convert.ToInt32(Console.ReadLine());

// int FirstEnd = 1;

// void Print(int starat ,int end)
// {
//     if(starat >=end) 
//     {Console.Write($"{starat}\t");
//     Print(starat-1 , end);
//     }

// }
// Print(nam,FirstEnd);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// System.Console.Write("Введите число M:");
// int nam1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число N:");
// int nam2 = Convert.ToInt32(Console.ReadLine());

// if (nam1<= nam2)
// {
//     int sum = CreateSum(nam1,nam2);
//     System.Console.WriteLine($"Сумма натуральных чисел от {nam1} до {nam2}: {sum}");
// }
// else 
// {
// System.Console.WriteLine("Ошибка: M должно быть меньше или равыно N");
// }


// int CreateSum(int start , int end)
// {
//     if (start > end)
//     {
//         return 0;
//     }
//     else
//     {
//         return start+CreateSum(start +1, end);
//     }
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

System.Console.Write("Введите число M:");
int nam1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N:");
int nam2 = Convert.ToInt32(Console.ReadLine());
int rezaut  =Accerman(nam1,nam2);

System.Console.WriteLine($"Сумма натуральных чисел от {nam1} до {nam2}: {rezaut}");


int Accerman(int m , int n)
{
if(m == 0)
{
    return n+1;
}
else if (m>0 && n ==0)
{
   return  Accerman(m-1,1);
}
else if (m>0 && n >0)
{
    return  Accerman(m-1,Accerman(m,n-1));
}
else
{
    return 0;
}
}