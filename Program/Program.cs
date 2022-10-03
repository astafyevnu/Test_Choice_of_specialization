// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите массив данных через запятую: ");
string[] array = Console.ReadLine()!.Split(',');
string[] newArray = new string[array.Length];

Console.WriteLine();
Console.Write("Новый массив: [");

for (int i = 0; i < array.Length; i++)
{
    if(array[i] == " world")
    {
        Console.Write(":-), ");
    } 
    else if(array[i].Length <= 3 && !string.IsNullOrWhiteSpace(array[i])) 
    {
        Console.Write(newArray[i] = array[i] + ", ");
    }
}
Console.Write("]");
Console.WriteLine();
Console.WriteLine();
