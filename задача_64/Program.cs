/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


*/
int GetNumber(string message)
{
   int result = 0;
   bool isCorrect = false;

   while(!isCorrect)
   {

    Console.WriteLine(message);

    if ((int.TryParse(Console.ReadLine(), out result) && (result >1 )) )
    {
        isCorrect = true;
    } 
    else
    {
        Console.WriteLine("Некорректно ввели число");
    }
   } 
   return result;
}

string f(int N)
{

        if (N ==1)
        {
            return "1";
        }
         return $"{N} {f(N-1)}";
}

Console.WriteLine(f(GetNumber("Введите число")));