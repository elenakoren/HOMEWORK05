/*Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел 
в массиве.
[345, 897, 568, 234]-> 2*/

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
    int[] array = new int[dimension];
    Random rnd = new Random();

    for(int i=0; i<dimension; i++)
    {
        array[i] = rnd.Next(100,1000);
    }
    return array;
}
void PrintArray(int[] array) 
{
    for (int i =0; i<array.Length; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine();
}

int CountNumbers(int[] array)
{
    int count = 0;
    for(int i=0;i<array.Length; i++)
    {
        if(array[i]%2==0)
    {
    count++;
    }
    }

return count;
}

int dim = GetNumber("Введите размерность массива");
int[] array = InitArray(dim);
PrintArray(array);
Console.WriteLine($"Количество четных чисел равно {CountNumbers(array)}");