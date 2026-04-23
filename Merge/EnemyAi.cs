public class EnemyAi
{
    public float DetectionRadius = 7000f;
    public float PatrolSpeed = 800f;

    public void Patrol()
    {
        Console.WriteLine($"Patrolling at speed {PatrolSpeed}");
    }
}