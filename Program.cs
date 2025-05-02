class Program
{

    static void Main()
    {
        string[] initialArray = ["B14", "A11", "B12", "A13"];
        //HandleSortArrays(initialArray);

        //HandleSplitAndJoins();
        //RevertWord();

        Formating();
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

    static void RevertWord()
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

    static void Formating()
    {

        string first = "Hello";
        string second = "World";

        // Composite formatting
        string result = string.Format("{0} - {1}!", first, second);

        Console.WriteLine(result);

        // local currency
        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");

        //percentages
        decimal tax = .36785m;
        Console.WriteLine($"Tax rate: {tax:P1}");

        //invoice example
        int invoiceNumber = 1201;
        decimal productShares = 25.4568m;
        decimal subtotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal total = 3185.19m;
        
        //
        Console.WriteLine("");
        string myWords = "Printting invoice for = ";
        myWords += (invoiceNumber.ToString()).PadLeft(12);
        Console.WriteLine(myWords.PadLeft(12));

        Console.WriteLine("");
        Console.WriteLine($"Invoice Number: {invoiceNumber}");
        Console.WriteLine($"   Shares: {productShares:N3} Product");
        Console.WriteLine($"     Sub Total: {subtotal:C}");
        Console.WriteLine($"           Tax: {taxPercentage:P2}");
        Console.WriteLine($"     Total Billed: {total:C}");

    // Pad examples
         Console.WriteLine(" \n");
    Console.WriteLine("C110".PadLeft(6, '0'));

    }
}
