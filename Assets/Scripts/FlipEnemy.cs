using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipEnemy : MonoBehaviour
{
    // Triggered when another collider enters this object's trigger collider
    void OnTriggerEnter2D(Collider2D enemy)
    {
        // Checks if the collider belongs to an object tagged as "Enemy"
        if (enemy.tag == "Enemy")
        {
        // Rotates the enemy by 180 degrees on the Y-axis to make it face the opposite direction
          enemy.transform.Rotate(0f, 180f, 0f);  
        }
       
    }
}
