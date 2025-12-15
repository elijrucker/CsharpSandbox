string[] pallets = ["B14", "A11", "B12", "A13"];
System.Console.WriteLine("");

Array.Clear(pallets, 0, 2);
System.Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    System.Console.WriteLine($"-- {pallet}");
}

System.Console.WriteLine("");
Array.Resize(ref pallets, 6);
System.Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    System.Console.WriteLine($"-- {pallet}");
}

System.Console.WriteLine("");
Array.Resize(ref pallets, 3);
System.Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    System.Console.WriteLine($"-- {pallet}");
}