// Final test
// Input data
string[] firstArray = { "hello", "2", "world", ":-)" };
string[] secondArray = { "1234", "1567", "-2", "computer science" };
string[] thirdArray = { "Russia", "Denmark", "Kazan" };

string[] FilterStringForLength(string[] arr, int strLength)
{
    return Array.FindAll(arr, s => s.Length <= strLength);
}

void PrintMyArray(string[] arr)
{
    foreach (var item in arr)
    {
        Console.WriteLine(item);
    }
}

PrintMyArray(FilterStringForLength(secondArray, 3));

