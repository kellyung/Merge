public class Player
{
    // TODO: branches will replace these 0 placeholders
    public float MoveSpeed = 4f;
    public float JumpForce = 1f;

    public void Move(float horizontal)
    {
        Console.WriteLine($"Moving at speed {MoveSpeed}, input: {horizontal}");
    }
}