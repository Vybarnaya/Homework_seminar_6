// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введите количество  чисел num :  ");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = new int [num];
CountNum(array);
PrintNumbers(num);
Console.WriteLine($"Количество чисел больше 0 = {CountNum(array)}");

void PrintNumbers(int numbers)
{
    for (int i = 0; i < numbers; i++)
    {
        Console.Write($"Введите {i+1}-ое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int CountNum (int [] arr) 
{
    int count = 0;
    for ( int i =0; i<arr.Length; i++)
    {
       if ( arr[i] >0)
        {
           count ++;
        }
    }
    return count ;
    
} 


