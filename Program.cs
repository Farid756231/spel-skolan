using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "Fantastiskt Äventyr";

        // Skapa en fördefinierad karta
        char[,] fördefinieradKarta = {
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

      
        RitaFärgadSpelplan(fördefinieradKarta);

        Console.ReadKey(); 
    }

    public static void RitaFärgadSpelplan(char[,] spelplan)
    {
        int rows = spelplan.GetLength(0);
        int cols = spelplan.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
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
            Console.WriteLine();
        }

        Console.ForegroundColor = ConsoleColor.White; // Återställ standardfärg
    }
}
