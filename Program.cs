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

List<Pokemon> pokedex = new();
pokedex.Add("Pikachu", "asd", 2, 3);

ShowHeader();

void ShowHeader()
{
    Console.WriteLine("╔═══════════════════════════╗");
    Console.WriteLine("| WELCOME TO KOFFES POKEDEX |");
    Console.WriteLine("╚═══════════════════════════╝");
    Console.ReadLine();

}