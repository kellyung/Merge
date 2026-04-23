public class Player
{
    // TODO: branches will replace these 0 placeholders
    public float MoveSpeed = 1000f;
    public float JumpForce = 30000f;

    public void Move(float horizontal)
    {
        Console.WriteLine($"Moving at speed {MoveSpeed}, input: {horizontal}");
    }
}