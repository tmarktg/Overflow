using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // The speed of the projectile
    public float speed = 5f;

    // Reference to the Rigidbody2D component for handling physics
    private Rigidbody2D rb;
    
    // Reference to the AudioManager for playing sound effects
    AudioManager audioManager;

    // Awake is called when the script instance is being loaded
    // Initializes the AudioManager reference by finding the object with the "Audio" tag
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Start is called before the first frame update
    // Initializes the Rigidbody2D component and sets the initial velocity of the projectile
    // Plays a sound effect for when the projectile is launched
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        audioManager.PlaySFX(audioManager.seahorse_sfx);
    }

    // Triggered when the projectile collides with another object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Checks if the projectile hit an object tagged as "Enemy"
        if (collision.tag == "Enemy")
        {
            // Reduces the enemy's life total by 1
            collision.GetComponent<EnemyBehavior>().LifeTotal--;

            // Plays a sound effect for hitting an enemy
            audioManager.PlaySFX(audioManager.enemy_hit);

            // Destroys the enemy object if its life total reaches zero
            if (collision.GetComponent<EnemyBehavior>().LifeTotal == 0) {
                Destroy(collision.gameObject);
            }

        }

        // Destroys the projectile upon collision with any object
        Destroy(gameObject);
    }
}
