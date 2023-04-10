class Program
{
    static void Main(string[] args)
    {
        string[] arr = { "apple", "banana", "cat", "dog", "egg", "fish", "goat" };

        string[] newArr = new string[arr.Length];
        int index = 0;
        foreach (string s in arr)
        {
            if (s.Length <= 3)
            {
                newArr[index] = s;
                index++;
            }
        }
        Array.Resize(ref newArr, index);

        Console.WriteLine(string.Join(", ", newArr));
    }
}
