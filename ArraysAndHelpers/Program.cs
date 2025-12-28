// /*
//     UNIT 2 OF 10
// */

// // Create an array of allets, then sort them
// string[] pallets = ["B14", "A11", "B12", "A13"];

// System.Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     System.Console.WriteLine($"-- {pallet}");
// }
// // Reverse the order of the same pallet array
// System.Console.WriteLine("");
// System.Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     System.Console.WriteLine($"-- {pallet}");
// }


/*
    UNIT 3 OF 10
*/
// Clearing and Resizing Arrays
string[] pallets = ["B14", "A11", "B12", "A13"];
System.Console.WriteLine("");

System.Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
System.Console.WriteLine($"After: {pallets[0]}");

System.Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    System.Console.WriteLine($"-- {pallet}");
}