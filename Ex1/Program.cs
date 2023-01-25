//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();


Write("Введите колличество чисел через пробел: ");
int[] array = Array.ConvertAll(ReadLine()!.Split(new char[] {' ', '.', ',',';',':'},StringSplitOptions.RemoveEmptyEntries), int.Parse);
WriteLine(SearchNumCount(array));


int SearchNumCount(int[] array)
{
    int count = 0;
       
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

