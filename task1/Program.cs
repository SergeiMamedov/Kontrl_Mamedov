// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string Prompt(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine() ?? " ";
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
int CountWordsWithLessThan3Symbols(string[] arr)
{
    int count = 0;
    foreach (string str in arr)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

    return count;
}

string[] CopyOnlyLessThan3Symbols(string[] initialArr)
{
    int copySize = CountWordsWithLessThan3Symbols(initialArr);
    string[] newArr = new string[copySize];

    int count = 0;
    foreach (string str in initialArr)
    {
        if (str.Length <= 3)
        {
            newArr[count++] = str;
        }
    }

    return newArr;
}
void ShowArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int size = Int32.Parse(Prompt("Size of array: "));
string[] arr = FillArray(size);
string[] duplicate = CopyOnlyLessThan3Symbols(arr);
ShowArr(duplicate);