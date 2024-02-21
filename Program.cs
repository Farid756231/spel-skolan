using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "Fantastiskt Äventyr";

        // Skapa en fördefinierad karta
        char[,] fördefinieradKarta = {
            { 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S'},
            { 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'S', 'S', 'B', 'H', 'B', 'S', 'S', 'B', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'S', 'S', 'B', 'H', 'B', 'S', 'S', 'B', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'S', 'S', 'B', 'H', 'B', 'S', 'S', 'B', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'S', 'S', 'B', 'H', 'B', 'S', 'S', 'B', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'S', 'S', 'B', 'H', 'B', 'S', 'S', 'B', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'S', 'S', 'B', 'H', 'B', 'S', 'S', 'B', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'S', 'S', 'B', 'H', 'B', 'S', 'S', 'B', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'S', 'S', 'B', 'H', 'B', 'S', 'S', 'B', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S', 'B', 'B', 'S', 'H', 'S', 'H', 'B', 'S', 'H', 'S' },
            { 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H' },
            { 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H' },
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
                    case 'B':
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case 'S':
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 'H':
                        Console.ForegroundColor = ConsoleColor.Blue; 
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
