public class Game
{
    public int StartingLives = 3; // ← changed from 0
    public int Score = 0;
    public void AddScore(int points)
    {
        Score += points;
        Console.WriteLine($"Score: {Score}");
    }
}