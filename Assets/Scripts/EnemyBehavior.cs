using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // The total life points of the enemy
    public int LifeTotal = 3;

    // The speed of the enemy
    public int EnemySpeed = 2;

    // The rigidbody of the enemy for physics manipulation
    public Rigidbody2D rb;
    
    
    // Start is called before the first frame update
    // Initializes the Rigidbody2D component for use in movement
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // Sets the enemy's velocity to move in the direction it's facing
    void Update()
    {
        rb.velocity = transform.right * EnemySpeed;
    }
}
