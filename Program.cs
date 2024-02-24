using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "Fantastiskt Äventyr";

        GameBoard gameBoard = new GameBoard();
        gameBoard.DrawBoard();

        Console.ReadKey();
    }
}
