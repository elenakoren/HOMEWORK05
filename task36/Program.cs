/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму
 элементов,стоящих на нечетных позициях.
[3, 7, 23, 12]-> 19
1-4, -6, 89, 6] -> */

int GetNumber(string message)
{ 
    int result;
    while(true)
    {
       Console.WriteLine(message);
       if(int.TryParse(Console.ReadLine(),out result))
       {
        break;
       }
       else
       {
        Console.WriteLine("Ввели не число.");
       }

    }
    return result;
}
int[] InitArray(int dimension)
{
    int[] array=new int [dimension];
    Random rnd = new Random();

    for(int i=0; i<dimension; i++)
    {
        array[i] = rnd.Next(-10,10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i =0; i<array.Length;i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine();
}
int GetPositivSumm(int[] array)
{
    int summ = 0;
    for (int i=0; i<array.Length; i++)
    {
        if(i%2!=0)
         summ += array[i];
    }
    return summ;
}

int dimension = GetNumber("Введите размерность массива");
int[] array = InitArray(dimension);
PrintArray(array);
int positivSumm = GetPositivSumm(array);
Console.WriteLine($"Сумма положительных:{positivSumm}");