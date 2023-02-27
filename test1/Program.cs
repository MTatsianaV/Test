/* Написать программу, которая:
1. из имеющегося массива строк формирует массив из строк 
с длинной менее или равной 3 символам.
2. Первоначальный массив можно ввести с клавиатуры
либо задать на старте выполнения алгоритма.
3. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Например:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer scince"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [" "] */
Console.WriteLine("Введите количество строк массива:");
int index = Convert.ToInt32(Console.ReadLine());
string[] CreateStringMass(int ind)
{
    string[] stringArray = new string[index];
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine("Введите строку:");
        stringArray[i] = Console.ReadLine();
    }
    return stringArray;
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1) Console.Write($", ");
    }
    Console.WriteLine("]");
}

string[] arr = CreateStringMass(index);
PrintArray(arr);
