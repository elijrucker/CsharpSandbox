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

// string input = "Pad this";
// System.Console.WriteLine(input.PadRight(12));
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// System.Console.WriteLine("1234567890123456789012345678901234567890");
// System.Console.WriteLine(formattedLine);


// ## UNIT 5 OF 8 ##

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
string customerAddress = $"Dear {customerName},\nAs a customer of our {currentProduct}" +
    "offering we are excited to tell you about a new financial product that would " +
    "dramatically increase your return.\n\n";
string customerProductData = $"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}\n\n";
string customerOffer = $"Our new product, {newProduct} offers a return of {newReturn:P2}. " +
    $"Given your current volume, your potential profit would be {newProfit:C}.\n";
System.Console.WriteLine(customerAddress + customerProductData + customerOffer);
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = $"{currentProduct}{currentReturn,16:P2}{currentProfit,16:C}\n" +
    $"{newProduct}{newReturn,12:P2}{newProfit,16:C}";

// Your logic here

Console.WriteLine(comparisonMessage);