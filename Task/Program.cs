string[] array1 = new string[4] {"hello", "2", "world", ":-)"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    if (array.Length > 0)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write('"');
            Console.Write($"{array[i]}");
            Console.Write('"');
            Console.Write(", ");
        }
        Console.WriteLine("]");
    }
    else
    {
        Console.WriteLine("[]");
    }
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);