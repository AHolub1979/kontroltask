// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше, либо равна 3 символам


string[] availableArray = new string[4] {"1234", "156", "-2", "computer science"};
string[] newArray = new string[availableArray.Length];
void SecondArray(string[] arrayA, string[] arrayN)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
    if(arrayA[i].Length <= 3)
        {
        arrayN[count] = arrayA[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"'{array[i]}', ");
    }
    Console.WriteLine();
}
SecondArray(availableArray, newArray);
PrintArray(newArray);