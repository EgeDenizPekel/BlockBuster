using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 4;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void collidedWithEnemy(Enemy enemy) // Collided with the enemy
    {
        enemy.Attack(this);
        if (health <= 0)
        {
            
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Enemy enemy = col.collider.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            collidedWithEnemy(enemy);
        }
    }
}
