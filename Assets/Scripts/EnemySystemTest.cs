using UnityEngine;

public class EnemySystemTest : MonoBehaviour
{
    void Start()
    {
        ComposedEnemy slowEnemy = new ComposedEnemy("Zombie", 1f);
        ComposedEnemy fastEnemy = new ComposedEnemy("Runner", 5f);

        slowEnemy.Move();
        fastEnemy.Move();
    }
}