// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на
// старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше
// обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] array1 = new string[]{"Hello", "World", "!!", ":-)"};


int GetSizeNewArray(string[] array1)
{
    int size = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            size++;
        }
        System.Console.WriteLine($"{array1[i]}");
    }
    return size;
}


void FillNewArray(string[] array1, string[] newArray)
{
    int newArrayIndex = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            newArray[newArrayIndex] = array1[i];
            newArrayIndex++;
            System.Console.WriteLine($"{array1[i]}");
        }
    }
}


int size = GetSizeNewArray(array1);
string[] newArray = new string[size];

System.Console.WriteLine();
FillNewArray(array1,newArray);
