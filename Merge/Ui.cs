public class Ui
{
    public float ScoreMultiplier = 100000f;

    public void DisplayScore(int score)
    {
        Console.WriteLine($"Score: {score * ScoreMultiplier}");
    }
}