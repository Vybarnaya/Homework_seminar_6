// /Напишите программу, которая будет создавать копию 
//заданного массива с помощью поэлементного копирования.
Console.Clear();
Console.WriteLine($"Введите длину массива size : ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива :");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива :");
int maxValue = Convert.ToInt32(Console.ReadLine());;
int [] array = CreateArr(size,minValue,maxValue);
int [] copy = CopyArray (array);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"[{String.Join(", ", copy)}]");

int [] CreateArr(int size, int minValue, int maxValue)
{
    int [] arr = new int [size];
    for (int i =0; i < size; i++)
    {
         arr [i] = new Random().Next( minValue, maxValue);
    }
    return arr;
}

int [] CopyArray (int [] arr)
{
    int n = arr.Length;
    int [] copyArr = new int [n];
    for ( int i =0; i < n; i++)
    {
         copyArr [i] = arr [i];
    }
    return copyArr;
}