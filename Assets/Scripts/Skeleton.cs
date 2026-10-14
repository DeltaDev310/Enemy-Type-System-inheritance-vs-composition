using UnityEngine;

public class Skeleton : Enemy
{
    public Skeleton() : base("Skeleton", 35, 15)
    {
    }

    public override void Attack()
    {
        Debug.Log("Skeleton fires an arrow!");
    }
}