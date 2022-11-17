// Final test
// Input data
string[] firstArray = { "hello", "2", "world", ":-)" };
string[] secondArray = { "1234", "1567", "-2", "computer science" };
string[] thirdArray = { "Russia", "Denmark", "Kazan" };
string[][] all = { firstArray, secondArray, thirdArray };

string[] FilterStringForLength(string[] arr, int strLength)
{
    return Array.FindAll(arr, s => s.Length <= strLength);
}

void PrintMyArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

for (int j = 0; j < all.Length; j++)
{
    Console.Write("[");
    PrintMyArray(FilterStringForLength(all[j], 3));
    Console.Write("]");
    Console.WriteLine();
}

