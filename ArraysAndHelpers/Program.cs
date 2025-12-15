/*
    Perform operations on arrays using helper methods in C#
    UNIT 3 OF 10
*/

// string[] pallets = ["B14", "A11", "B12", "A13"];
// System.Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// System.Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     System.Console.WriteLine($"-- {pallet}");
// }

// System.Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// System.Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     System.Console.WriteLine($"-- {pallet}");
// }

// System.Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// System.Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     System.Console.WriteLine($"-- {pallet}");
// }

/*
    Perform operations on arrays using helper methods in C#
    UNIT 4 OF 10
*/
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// //string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// System.Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     System.Console.WriteLine(item);
// }

/*
    Perform operations on arrays using helper methods in C#
    UNIT 5 OF 10
*/
string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramSplit = pangram.Split(' ');
string[] newPangram = new string[pangramSplit.Length];
for (int i = 0; i < pangramSplit.Length; i++)
{
    char[] letters = pangramSplit[i].ToCharArray();
    Array.Reverse(letters);
    newPangram[i] = new string(letters);
}
string result = String.Join(" ", newPangram);
System.Console.WriteLine(result);