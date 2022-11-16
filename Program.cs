/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N. Выполнить с помощью рекурсии. */

int GetSum(int m, int n)
{   
    int sum;
     
    if (m >= n)
       return m;
    else
    {
        return sum = n + GetSum(m, n - 1);
    }
    
}
Console.WriteLine(GetSum(1, 5));

  
