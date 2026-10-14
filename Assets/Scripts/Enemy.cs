using UnityEngine;

public class Enemy
{
    public string enemyName;
    public int health;
    public int damage;

    public Enemy(string name, int hp, int dmg)
    {
        enemyName = name;
        health = hp;
        damage = dmg;
    }

    public virtual void Attack()
    {
        Debug.Log(enemyName + " attacks for " + damage + " damage!");
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health < 0)
        {
            health = 0;
        }

        Debug.Log(enemyName + " has " + health + " health left.");

        if (health == 0)
        {
            Debug.Log(enemyName + " has been defeated!");
        }
    }
}