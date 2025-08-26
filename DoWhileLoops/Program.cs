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

int heroHealth = 10;
int monsterHealth = 10;
Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monsterHealth -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterHealth} health.");

    if (monsterHealth <= 0) continue;

    roll = dice.Next(1, 11);
    heroHealth -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} and now has {heroHealth} health.");
} while ((heroHealth > 0) && (monsterHealth > 0));

Console.WriteLine( heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");