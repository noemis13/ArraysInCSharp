class Program
{

    static void Main()
    {
        string[] initialArray = ["B14", "A11", "B12", "A13"];
        //HandleSortArrays(initialArray);

        //HandleSplitAndJoins();
        ReverWord();
    }


    static void PrintArray(Array arrayValues)
    {
        foreach (var pallet in arrayValues)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }


    static void HandleSortArrays(string[] pallets)
    {
        Console.WriteLine("Sorted...");
        Array.Sort(pallets);

        // Show array
        PrintArray(pallets);

        Console.WriteLine(" ");
        Console.WriteLine("Reversed...");
        Array.Reverse(pallets);
        // Show array
        PrintArray(pallets);

        Console.WriteLine($"Length = {pallets.Length} ");

        Console.WriteLine(" ");

        // Clear array
        Console.WriteLine($"Before: {pallets[0]}");
        Array.Clear(pallets, 0, 2);
        // Show array
        PrintArray(pallets);

        Console.WriteLine($"Length after index removal = {pallets.Length} ");

        // resize array

        Console.WriteLine("");
        Array.Resize(ref pallets, 6);
        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

        pallets[4] = "C01";
        pallets[5] = "C02";

        // Show array
        PrintArray(pallets);

        Console.WriteLine("");
        Array.Resize(ref pallets, 3);
        Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

        // Show array
        PrintArray(pallets);

    }

    static void HandleSplitAndJoins()
    {

        string value = "abc123";

        // create an array
        char[] valueArray = value.ToCharArray();

        // rever array
        Array.Reverse(valueArray);

        string result = new string(valueArray);
        Console.WriteLine(result);

        result = String.Join(",", valueArray);
        Console.WriteLine(result);

        string[] items = result.Split(',');
        PrintArray(items);
    }

    static void ReverWord()
    {
        // reverse the following expression
        string pangram = "The quick brown fox jumps over the lazy dog";


        // Step 1
        string[] message = pangram.Split(' ');

        //Step 2
        string[] newMessage = new string[message.Length];

        // Step 3
        for (int i = 0; i < message.Length; i++)
        {
            char[] letters = message[i].ToCharArray();
            Array.Reverse(letters);
            newMessage[i] = new string(letters);
        }

        //Step 4
        string result = String.Join(" ", newMessage);
        Console.WriteLine(result);

    }

}
