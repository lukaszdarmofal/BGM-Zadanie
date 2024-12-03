
using System;
namespace BGS;

public class Player
{
    // Konstruktor klasy gracza.
    
    public string PlayerName;
    public int PlayerPosition;
    public int PlayerScore;

    public Player(string name)
    {
        PlayerName = name;
        PlayerPosition = 0;
        PlayerScore = 0;
    }
    
    // Metody klasy
    
    // ruch gracza
    public void PlayerMove(int step)
    {
        if (step == 0)
        {
            Console.WriteLine($"Player {PlayerName} tried to move forward, but they can't!");
        }
        else
        {
            PlayerPosition += step;
            Console.WriteLine($"Player {PlayerName} moved {step} tiles forward!\nThey are now on tile {PlayerPosition}.");
        }
    }
    
    // inkrementowanie punktów gracza
    public void PlayerGainScore(int increment)
    {
        PlayerScore += increment;
        Console.WriteLine($"{PlayerName} increased their score by {increment}.\nThey now have {PlayerScore} score!");
    }
    
    
}

public class Board
{
    // Konstruktor klasy planszy
    
    public int BoardSize;
    public int[] BoardSpecial;

    public Board(int size = 100)
    {
        BoardSize = size;
    }
    
    // Metoda generująca specjalne pola na planszy
    
    public void BoardGenerate()
    {
        if (BoardSize <= 100) // dla małej planszy (<=100)
        {
            int specialAmount = BoardSize / 5;
            BoardSpecial = new int[specialAmount+1];
            int randomField;
            Random rnd = new Random();
            
            for (int i = 0; i <= specialAmount; i++)
            {
                randomField = rnd.Next(1, BoardSize + 1);
                BoardSpecial[i] = randomField;
            }
        }
        else // dla większej planszy (>100)
        {
            int specialAmount = BoardSize / 3;
            BoardSpecial = new int[specialAmount+1];
            int randomField;
            Random rnd = new Random();
            
            for (int i = 0; i <= specialAmount; i++)
            {
                randomField = rnd.Next(1, BoardSize + 1);
                BoardSpecial[i] = randomField;
            }
        }
    }
    
}

public class Game
{
    
}

internal class Program
{
    public static void Main(string[] args)
    {
        bool isOnSpecialField;
        bool isTakingAnItem;

        Player gracz1 = new Player("Marek");
        gracz1.PlayerGainScore(13);
        gracz1.PlayerMove(3);
        Console.WriteLine($"{gracz1.PlayerName}, {gracz1.PlayerPosition}, {gracz1.PlayerScore}");

        Board Plansza1 = new Board();
        Board Plansza2 = new Board(150);
        
        Plansza1.BoardGenerate();
        Plansza2.BoardGenerate();
        
        Console.WriteLine($"\nPlansza 1 :");
        foreach (var i in Plansza1.BoardSpecial)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine($"\nPlansza 2 :");
        foreach (var i in Plansza2.BoardSpecial)
        {
            Console.WriteLine(i);
        }


    }
}

