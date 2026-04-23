public class EnemyAi
{
    public float DetectionRadius = 0f;
    public float PatrolSpeed = 4f;

    public void Patrol()
    {
        Console.WriteLine($"Patrolling at speed {PatrolSpeed}");
    }
}