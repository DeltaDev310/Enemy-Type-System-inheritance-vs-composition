using UnityEngine;

public class Goblin : Enemy
{
    public Goblin() : base("Goblin", 50, 10)
    {
    }

    public override void Attack()
    {
        Debug.Log("Goblin slashes with its dagger!");
    }
}