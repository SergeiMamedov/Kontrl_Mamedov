// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string Prompt(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

string[] FillArray(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Prompt($"Write {i} element: ");
    }

    return arr;
}
