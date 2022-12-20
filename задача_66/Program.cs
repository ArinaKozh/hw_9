/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int GetNumber(string message)
{
   int result = 0;
   bool isCorrect = false;

   while(!isCorrect)
   {

    Console.WriteLine(message);

    if ((int.TryParse(Console.ReadLine(), out result) && (result >=1 )) )
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

int Sum(int N,int M)
{
    if (M==N)
    {
        return N;
    }

    else
    {
        return M+N+Sum(N+1,M-1);
    }
}

Console.WriteLine(Sum(GetNumber("число N"),GetNumber("число M")));