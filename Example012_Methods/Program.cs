// Вид 1 - например, указание авторства

void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

// Вид 2

void Method2(string msg1)
{
    Console.WriteLine(msg1);
}
Method2("Текст сообщения 1");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(count: 4, msg: "Текст сообщения");

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);

// Цикл for
// for (int i = 0; i < count; i++)
// {
//     result = result + text;
// }
// return result

int[] arr = {1, 2, 3, 5, 2, 9, 4};

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {

    int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[minPosition]) minPosition = j;
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
    }
}