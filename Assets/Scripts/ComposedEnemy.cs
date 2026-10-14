public class ComposedEnemy
{
    public string enemyName;
    public EnemyMovement movement;

    public ComposedEnemy(string name, float speed)
    {
        enemyName = name;
        movement = new EnemyMovement(speed);
    }

    public void Move()
    {
        movement.Move();
    }
}