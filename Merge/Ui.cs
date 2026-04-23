public class Ui
{
    public float ScoreMultiplier = 1.5f; // ← changed from 0f
    public void DisplayScore(int score)
    {
        Console.WriteLine($"Score: {score * ScoreMultiplier}");
    }
}