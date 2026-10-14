public class EnemyMovement
{
    public float speed;

    public EnemyMovement(float speed)
    {
        this.speed = speed;
    }

    public void Move()
    {
        UnityEngine.Debug.Log("Enemy moves at speed " + speed);
    }
}