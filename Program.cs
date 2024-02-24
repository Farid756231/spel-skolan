

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "Fantastiskt Äventyr";

        // Skapa en fördefinierad karta
        char[,] fördefinieradKarta = {
            // Din fördefinierade karta här
           
            { 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S'},
            { 'S', 'S', 'S', 'S', 'S', 'D', 'D', 'D', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S' },
            { 'S', 'D', 'D', 'D', 'S', 'D', 'D', 'D', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S' },
            { 'S', 'D', 'D', 'D', 'S', 'S', 'B', 'S', 'S', 'S', 'D', 'D', 'D', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S' },
            { 'S', 'S', 'B', 'D', 'D', 'D', 'S', 'D', 'D', 'D', 'D', 'D', 'D', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S' },
            { 'S', 'S', 'S', 'D', 'D', 'D', 'S', 'D', 'D', 'D', 'S', 'B', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S' },
            { 'S', 'D', 'D', 'D', 'B', 'S', 'S', 'S', 'B', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S' },
            { 'S', 'D', 'D', 'D', 'D', 'D', 'D', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S'},
            { 'S', 'S', 'B', 'S', 'D', 'D', 'D', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S' },
            { 'S', 'S', 'S', 'S', 'S', 'B', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S' },
            { 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'R', 'R', 'S', 'R', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S' },
            { 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'R', 'S', 'S', 'S', 'S', 'S', 'S', 'S' },
            { 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'R', 'S', 'R', 'R', 'S', 'R', 'S', 'S', 'S', 'S', 'S', 'S' },
            { 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'R', 'R', 'B', 'R', 'S', 'S', 'S', 'S', 'S', 'S', 'S' },
            { 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'R', 'B', 'R', 'B', 'R', 'R', 'S', 'S', 'S', 'S', 'S', 'S'},
            { 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'R', 'B', 'B', 'R', 'B', 'R', 'B', 'R', 'S', 'S', 'S', 'S', 'S' },
            { 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'R', 'B', 'B', 'B', 'R', 'B', 'R', 'B', 'B', 'R', 'S', 'S', 'S', 'S' },
            { 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'R', 'B', 'B', 'B', 'R', 'R', 'B', 'B', 'B', 'B', 'R', 'R', 'S', 'S', 'S' },
            { 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'B', 'B', 'B', 'B', 'R', 'B', 'B', 'B', 'B', 'B', 'R', 'B', 'S', 'S', 'S' },
            { 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'B', 'B', 'B', 'B', 'R', 'R', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'S', 'S' },
            { 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', 'B', 'B', 'B', 'B', 'B', 'R', 'R', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'S' },
            { 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'R', 'R', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y' },
            { 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'R', 'R', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y' },
            { 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'R', 'R', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H' },
            { 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H' },
            { 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H' }

   
        };

        // Skapa en spelare
        Player player = new Player(1, 1);

        // Skapa olika typer av varelser med olika symboler, egenskaper och placera dem på spelplanen
        Creature[] creatures = {
            new Creature(3, 5, 'S', ConsoleColor.Red, 10, 20, 5),
            new Creature(8, 10, 'L', ConsoleColor.Red, 15, 25, 3),
            new Creature(12, 15, 'T', ConsoleColor.Red, 12, 18, 7),
            new Creature(17, 20, 'C', ConsoleColor.Red, 20, 30, 2),
            new Creature(5, 15, 'U', ConsoleColor.Red, 8, 22, 6),
            new Creature(10, 5, 'K', ConsoleColor.Red, 18, 28, 4),
            new Creature(20, 10, 'P', ConsoleColor.Red, 25, 35, 8),
            new Creature(15, 3, 'N', ConsoleColor.Red, 30, 40, 10),
            new Creature(10, 18, 'V', ConsoleColor.Red, 22, 32, 5),
            new Creature(18, 5, 'R', ConsoleColor.Red, 28, 38, 7)
        };

        // Skapa olika typer av föremål med olika egenskaper och placera dem på spelplanen
        Item[] items = {
            new Item(2, 3, 'A', ConsoleColor.Yellow, "Amulet", "+10 Health"),
            new Item(7, 8, 'R', ConsoleColor.Magenta, "Ring", "+5 Strength"),
            new Item(13, 16, 'B', ConsoleColor.Cyan, "Boots", "+3 Speed"),
            new Item(19, 4, 'S', ConsoleColor.DarkYellow, "Sword", "+8 Attack"),
            new Item(6, 18, 'H', ConsoleColor.DarkMagenta, "Helmet", "+6 Defense")
        };

 
        

          
        ConsoleKeyInfo keyInfo;

       
       
        do
        {

                // Rita spelplanen med spelaren, varelser och föremål
            RitaFärgadSpelplan(fördefinieradKarta, player, creatures, items);

            // Rita spelarens kraft och egenskaper för varelser och föremål under spelplanen
            RitaSpelarensKraftOchEgenskaper(player, creatures, items);
            
            // Hantera spelarinput
            keyInfo = Console.ReadKey(true);

            // Spara den gamla positionen för spelaren
            int oldX = player.X;
            int oldY = player.Y;

            // Uppdatera spelarens position baserat på inputen
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (player.Y > 0 && fördefinieradKarta[player.Y - 1, player.X] != 'M')
                        player.Y--;
                    break;
                case ConsoleKey.DownArrow:
                    if (player.Y < fördefinieradKarta.GetLength(0) - 1 && fördefinieradKarta[player.Y + 1, player.X] != 'M')
                        player.Y++;
                    break;
                case ConsoleKey.LeftArrow:
                    if (player.X > 0 && fördefinieradKarta[player.Y, player.X - 1] != 'M')
                        player.X--;
                    break;
                case ConsoleKey.RightArrow:
                    if (player.X < fördefinieradKarta.GetLength(1) - 1 && fördefinieradKarta[player.Y, player.X + 1] != 'M')
                        player.X++;
                    break;
            }

            // Återställ spelarens position om den nya positionen är utanför spelplanen
            if (player.X < 0 || player.X >= fördefinieradKarta.GetLength(1) ||
                player.Y < 0 || player.Y >= fördefinieradKarta.GetLength(0))
            {
                player.X = oldX;
                player.Y = oldY;
            }

              // Rensa endast den gamla positionen för spelaren på spelplanen
    Console.SetCursorPosition(oldX, oldY);

    Console.Write(fördefinieradKarta[oldY, oldX]); // Rita över den gamla positionen på spelplanen med dess bakgrundsfärg

    // Rita spelaren på den nya positionen
    Console.SetCursorPosition(player.X, player.Y);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write('P');




                foreach (var item in items)
        {
            if (player.X == item.X && player.Y == item.Y)
            {
                // Apply item's effects to the player
                ApplyItemEffects(player, item);

                // Remove the item from the items array
                items = items.Where(i => i != item).ToArray();
                break; // Exit the loop after picking up one item per turn
            }
        }
           
          Console.Clear();  // Rensa konsolfönstret för att rita om

        } while (keyInfo.Key != ConsoleKey.Escape); // Avsluta om spelaren trycker på Escape

      
    }

      
    public static void ApplyItemEffects(Player player, Item item)
{
    // Apply item effects to the player
    // For simplicity, let's assume the effect is to increase the player's power
    player.Power += 10; // Increase player's power by 10 (you can modify this based on item effects)
    Console.WriteLine($"You picked up {item.Name}! Your power increased by 10.");
}

    public static void RitaSpelarensKraftOchEgenskaper(Player player, Creature[] creatures, Item[] items)
    {
        Console.WriteLine("\n\nSpelarens kraft och egenskaper:");

        // Visa spelarens kraft
        Console.WriteLine($"Kraft: {player.Power}");

        // Visa egenskaperna för varelser
        Console.WriteLine("\nVarelsernas egenskaper:");
        foreach (var creature in creatures)
        {
            Console.WriteLine($"Symbol: {creature.Symbol}, Styrka: {creature.Strength}, Livskraft: {creature.Health}, Hastighet: {creature.Speed}");
        }

        // Visa egenskaperna för föremål
        Console.WriteLine("\nFöremålens egenskaper:");
        foreach (var item in items)
        {
            Console.WriteLine($"Symbol: {item.Symbol}, Namn: {item.Name}, Effekt: {item.Effect}");
        }
    }

    public static void RitaFärgadSpelplan(char[,] spelplan, Player player, Creature[] creatures, Item[] items)
    {

       
        int rows = spelplan.GetLength(0);
        int cols = spelplan.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Rita spelaren
                if (player.X == j && player.Y == i)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("P");
                }
                // Rita varelser
                else
                {
                    bool entityPlaced = false;
                    foreach (var creature in creatures)
                    {
                        if (creature.X == j && creature.Y == i)
                        {
                            Console.ForegroundColor = creature.Color;
                            Console.Write(creature.Symbol);
                            // Visa varelsernas egenskaper
                            // Console.ForegroundColor = ConsoleColor.White;
                            // Console.Write($" (Egenskaper: Styrka {creature.Strength}, Livskraft {creature.Health}, Hastighet {creature.Speed}) ");
                            entityPlaced = true;
                            break;
                        }
                    }
                    // Rita föremål
                    if (!entityPlaced)
                    {
                        foreach (var item in items)
                        {
                            if (item.X == j && item.Y == i)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write(item.Symbol);
                                // Visa föremålets egenskaper
                                // Console.ForegroundColor = ConsoleColor.White;
                                // Console.Write($" (Föremål: {item.Name}, Effekt: {item.Effect}) ");
                                entityPlaced = true;
                                break;
                            }
                        }
                    }
                    // Rita spelplanens övriga delar om ingen spelare, varelse eller föremål är placerade på denna position
                    if (!entityPlaced)
                    {
                        switch (spelplan[i, j])
                        {
                            case 'D':
                             Console.ForegroundColor = ConsoleColor.DarkGray;
                             break;
                            case 'B':
                             Console.ForegroundColor = ConsoleColor.Black;
                             break;
                            case 'S':
                             Console.ForegroundColor = ConsoleColor.Green;
                             break;
                            case 'H':
                             Console.ForegroundColor = ConsoleColor.Blue;
                             break;
                            case 'Y':
                             Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                            case 'R':
                             Console.ForegroundColor = ConsoleColor.Red;
                             break;

                             default:
                             Console.ForegroundColor = ConsoleColor.White;
                             break;
                        }
                        Console.Write("█");
                    }
                }
            }
            Console.WriteLine();
        }
           
       
        Console.ForegroundColor = ConsoleColor.White; // Återställ standardfärg
    }
}


// Basentitetsklass
public class Entity
{
    public int X { get; set; }
    public int Y { get; set; }

    public Entity(int x, int y)
    {
        X = x;
        Y = y;
    }
}

// Spelarklass som ärver från Entity
public class Player : Entity
{
    public int Power { get; set; }

    public Player(int x, int y) : base(x, y)
    {
        Power = 100; // Exempelvis startkraft
    }
}

// Fiendeklass som ärver från Entity
public class Creature : Entity
{
    public char Symbol { get; set; } // Lägg till egenskapen Symbol
    public ConsoleColor Color { get; set; }
    public int Strength { get; set; }
    public int Health { get; set; }
    public int Speed { get; set; }

    public Creature(int x, int y, char symbol, ConsoleColor color, int strength, int health, int speed) : base(x, y)
    {
         Symbol = symbol;
        Color = color;
        Strength = strength;
        Health = health;
        Speed = speed;
    }
}

// Föremålsklass som ärver från Entity
public class Item : Entity
{
    public char Symbol { get; set; }
    public ConsoleColor Color { get; set; }
    public string Name { get; set; }
    public string Effect { get; set; }

    public Item(int x, int y, char symbol, ConsoleColor color, string name, string effect) : base(x, y)
    {
        Symbol = symbol;
        Color = color;
        Name = name;
        Effect = effect;
    }
}