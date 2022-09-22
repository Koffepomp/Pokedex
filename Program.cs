// Pokedex

// Skapa en class “Pokémon” som innehåller följande field variables:
// string name // Namnet på Pokémonen, t.ex. Bulbasaur
// string type // T.ex. Poison eller Fire eller Water beroende på
// int totalForms // Beskriver totala antalet former (evolutions) som Pokémonen har 🌶
// int currentForm // Beskriver den nuvarande formen (evolutionen) som Pokémonen har 🌶

// Använd Constructorn i Pokémon-klassen för att “sätta” alla field variables ovan när en Pokémon skapas

// I Pokemon-klassen, skapa metoder för att “evolva” Pokémonen (öka currentForm med 1) 🌶
// Tänk på att currentForm inte ska kunna överstiga totalForms 🌶

// Om möjligt, ändra namnet på din Pokémon så det överensstämmer med currentForm 🌶

// I Program.cs, skapa en lista med Pokémons

// Skapa metoder för att displaya, lägga till och ta bort Pokémons från listan i Program.cs

// Låt användaren bestämma om den vill lägga till, ta bort eller displaya med hjälp av input från en Console.ReadLine();

// När Pokémon displayas, så ska deras nuvarande form visas också 🌶

//------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------

using Pokedex;

bool running = true;

List<Pokemon> pokedex = new();
pokedex.Add(new Pokemon("Pikachu", "Raichu", "", "Lightning", 1, 2, "Pikachu that can generate powerful electricity have cheek sacs that are extra soft and super stretchy."));
pokedex.Add(new Pokemon("Charmander", "Charmeleon", "Charizard", "Fire", 1, 3, "It has a preference for hot things. When it rains, steam is said to spout from the tip of its tail."));
pokedex.Add(new Pokemon("Squirtle", "Wartortle", "Blastoise", "Water", 1, 3, "When it retracts its long neck into its shell, it squirts out water with vigorous force."));
pokedex.Add(new Pokemon("Bulbasaur", "Ivysaur", "Venusaur", "Grass", 1, 3, "There is a plant seed on its back right from the day this Pokémon is born. The seed slowly grows larger."));

while (running)
{

ShowHeader();

ShowPokedex();

AskUserAction();

}

void ShowHeader()
{
    Console.Clear();
    Console.WriteLine("╔═══════════════════════════╗");
    Console.WriteLine("| WELCOME TO KOFFES POKEDEX |");
    Console.WriteLine("╚═══════════════════════════╝");
}

void ShowPokedex()
{
    int pokedexSlot = 1;

    foreach(Pokemon pokemon in pokedex)
    {
        Console.WriteLine($"#{pokedexSlot}: {pokemon.Name()}");
        pokedexSlot++;
    }
}

void AskUserAction()
{
    Console.Write("\nInsert a number to read more about a pokemon, or add/remove: ");
    string userInput = Console.ReadLine();
    if (userInput == "add")
    {
        AddPokemonToPokedex();
    }
    else if (userInput == "remove")
    {
        PickPokemonToRemove();
    }
    else
    {
        int userInputInt = Convert.ToInt32(userInput);
        PreviewPokemon(userInputInt);
    }
}

void AddPokemonToPokedex()
{
    Console.Write("\nWhat's the first stage name of the pokemon? ");
    string inputName1 = Console.ReadLine();
    Console.Write("\nWhat's the second stage name of the pokemon? ");
    string inputName2 = Console.ReadLine();
    Console.Write("\nWhat's the third stage name of the pokemon? ");
    string inputName3 = Console.ReadLine();
    Console.Write("\nWhat's the type of the pokemon? ");
    string inputType = Console.ReadLine();
    Console.Write("\nWhat's the current form of the pokemon? ");
    int inputCurrentForm = Convert.ToInt32(Console.ReadLine());
    Console.Write("\nWhat's the total number of stages of the pokemon? ");
    int inputTotalForms = Convert.ToInt32(Console.ReadLine());
    Console.Write("\nWrite a description of the pokemon: ");
    string inputDesc = Console.ReadLine();

    pokedex.Add(new Pokemon(inputName1, inputName2, inputName3, inputType, inputCurrentForm, inputTotalForms, inputDesc));
    Console.WriteLine("\nPokemon successfully added to the pokedex!");
    Console.ReadLine();
}

void PickPokemonToRemove()
{
    Console.Write("\nWhich pokemon do you want to remove? ");
    int userIndexRemove = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.WriteLine($"\n{pokedex[userIndexRemove].Name()} successfully removed from the pokedex!");

    pokedex.Remove(pokedex[userIndexRemove]);
    Console.ReadLine();
}

void PreviewPokemon(int userInputInt)
{
    int pokedexSlot = userInputInt - 1;
    Console.WriteLine("\nName: " + pokedex[pokedexSlot].Name() + pokedex[pokedexSlot].AllNames());
    Console.WriteLine("Type: " + pokedex[pokedexSlot].Type());
    Console.WriteLine("Evolution Stage: " + pokedex[pokedexSlot].CurrentForm() + "/" + pokedex[pokedexSlot].TotalForms());
    Console.WriteLine("\nDescription: " + pokedex[pokedexSlot].Desc());
    Console.ReadLine();
}