// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// System.Console.WriteLine(result);
// System.Console.WriteLine("{1} {0}!", first, second);
// System.Console.WriteLine("{0} {0} {0}!", first, second);
// System.Console.WriteLine($"{first} {second}!");
// System.Console.WriteLine($"{second} {first}!");
// System.Console.WriteLine($"{first} {first} {first}!");

// decimal price = 123.45m;
// int discount = 50;
// System.Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// decimal measurement = 123456.78912m;
// System.Console.WriteLine($"Measurement: {measurement:N4} units");

// decimal tax = .36785m;
// System.Console.WriteLine($"Tax rate: {tax:P2}");

// decimal price = 67.55m;
// decimal salePrice = 59.99m;
// string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
// yourDiscount += $"A discount of {((price - salePrice) / price):P2}!";
// System.Console.WriteLine(yourDiscount);


//## UNIT 3 OF 8 ##

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// System.Console.WriteLine($"Invoice Number: {invoiceNumber}");
// System.Console.WriteLine($"    Shares: {productShares:N3} Product");
// System.Console.WriteLine($"    Sub Total: {subtotal:C}");
// System.Console.WriteLine($"    Tax: {taxPercentage:P2}");
// System.Console.WriteLine($"    Total Billed: {total:C}");


// ## UNIT 4 OF 8 ##

string input = "Pad this";
System.Console.WriteLine(input.PadRight(12));