/*
    Units 1 - 2
*/

// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);
//     if (current >= 8) continue;
//     Console.WriteLine(current);
// } while (current != 7);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");


/*
    Unit 3 - RPG Challenge
*/

// int heroHealth = 10;
// int monsterHealth = 10;
// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monsterHealth -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterHealth} health.");

//     if (monsterHealth <= 0) continue;

//     roll = dice.Next(1, 11);
//     heroHealth -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} and now has {heroHealth} health.");
// } while ((heroHealth > 0) && (monsterHealth > 0));

// Console.WriteLine( heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");


/*
    Unit 5 - Code Project 1
*/
// string? readResult;
// string valueEntered = "";
// int numValue = 0;
// bool validEntry = false;

// Console.WriteLine("Please enter a number between 5 and 10");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         valueEntered = readResult;
//     }

//     validEntry = int.TryParse(valueEntered, out numValue);

//     if (validEntry == true)
//     {
//         if (numValue <= 5 || numValue >= 10)
//         {
//             validEntry = false;
//             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again.");
//     }
// } while (validEntry == false);
// Console.WriteLine($"Your input value ({numValue}) has been accepted. Thank you for your input.");
// readResult = Console.ReadLine();


/*
    Unit 5 - Code Project 2
*/
string? readResult;
string roleName = "";
bool validEntry = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator"
        || roleName.ToLower() == "manager"
        || roleName.ToLower() == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.WriteLine($"The role name you entered, \"{roleName}\" does not exist.");
    }
} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted");
readResult = Console.ReadLine();