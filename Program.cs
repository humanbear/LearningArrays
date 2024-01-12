// See https://aka.ms/new-console-template for more information

//Grades

int[] grades = new int[10]; // init array of intergers

grades[0] = 5;
grades[1] = 9;
grades[2] = 10;
grades[3] = 6;
grades[4] = 7;
grades[5] = 4;
grades[6] = 8;
grades[7] = 9;
grades[8] = 4;
grades[9] = 5;




    //Console.WriteLine($"The first grade in the array is {grades[0]}");
    //Console.WriteLine($"The highest grade was {grades[2]}");

Console.WriteLine($"In total, there are {grades.Length} grades");
Console.WriteLine($"The average of the grades is: {grades.Average()}");
Console.WriteLine($"The best grade was {grades.Max()} the worst grade was {grades.Min()}");

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"At index {i} we have grade {grades[i]}");
}

int sumOfGrades = 0;
for (int i = 0;i < grades.Length; i++)
{
    sumOfGrades += grades[i];
}
Console.WriteLine($"The sum of grades is {sumOfGrades}");
Console.WriteLine($"The average of the grades is {(float)sumOfGrades / grades.Length}");

Console.WriteLine();

//==Friends==

string[] friends = { "Bob", "Liza", "Kevin" };
Console.WriteLine($"My best friend is {friends[0]}");
Console.WriteLine($"My second best friend is {friends[1]}");
Console.WriteLine($"And last, but not least I am also very fond of {friends[friends.Length - 1]}");

string oldFriend = friends[0];
friends[0] = "Kathy";

Console.WriteLine($"Something happended and I had a falling out with {oldFriend} :'( ...But the upshot is that my new best friend is {friends[0]}");

for (int i = 0;i < friends.Length;i++)
{
    Console.WriteLine($"{friends[i]} is my friend.");
}

Console.WriteLine();

// ==BackPack==
string[] itemsInBackpack = new string[6];
itemsInBackpack[0] = "Biscuits";
itemsInBackpack[1] = "Nap Blanket";
itemsInBackpack[2] = "Sword of Destiny";
itemsInBackpack[3] = "Skull of enemy goblin";
itemsInBackpack[4] = "An apple";
itemsInBackpack[5] = "Deck of Cards";

Console.WriteLine($"Items in my backpack are:");
for(int i = 0; i<itemsInBackpack.Length;i++)
{
    Console.WriteLine($"\t-{itemsInBackpack[i]}");
}

// == Favorite Foods App==

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("How many favourite foods do you have?");
int numberOfFavouriteFoods = -1;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out numberOfFavouriteFoods) && numberOfFavouriteFoods > 0)
    {
        Console.WriteLine("That is a nice number.");
        break; //break out of the while loop
    }
    Console.WriteLine("Sorry, use a whole number larger than zero!");
}
Console.WriteLine("Type in the names of your favorite dishes!");

string[] favoriteFoods = new string[numberOfFavouriteFoods];

for (int i = 0; i < favoriteFoods.Length; i++)
{
    Console.WriteLine($"The dish number {i+1} is:");
    string answer = Console.ReadLine();
    while (string.IsNullOrEmpty(answer))
    {
        Console.WriteLine("Sorry, type answer again!");
        answer = Console.ReadLine();
    }
    favoriteFoods[i] = answer;
}

Console.WriteLine();
Console.WriteLine($"You have {favoriteFoods.Length} favorite foods, which are:");
/*
for (int i = 0; i < favoriteFoods.Length; i++)
{
    Console.WriteLine($"\t-{favoriteFoods[i]}");
}
*/

foreach (string food in favoriteFoods)
{
    Console.WriteLine(food);
}


