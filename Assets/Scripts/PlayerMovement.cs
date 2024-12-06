using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Stores the horizontal input value (-1 for left, 1 for right, 0 for no input)
    private float horizontal;

    // Player movement speed
    public float speed = 5f;

    // Jump force applied to the player
    public float jumpPower = 5f;

    // Tracks whether the player is facing right
    private bool FacingRight = true;

    // Reference to the Rigidbody2D component for physics manipulation
    private Rigidbody2D rb;

    // Reference to the AudioManager for playing sound effects
    AudioManager audioManager;

    // Called when the script instance is loaded
    // Initializes the AudioManager by finding the object tagged as "Audio"
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Start is called before the first frame update
    // Initializes the Rigidbody2D component for controlling player movement
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // Handles player movement, jumping, and flipping direction based on input
    void Update()
    {
        // Gets horizontal input for left/right movement
        horizontal = Input.GetAxisRaw("Horizontal");

        // Sets the horizontal velocity based on input and movement speed, while keeping the current vertical velocity
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        
        // Checks if the player presses the jump button and is on the ground (y velocity is 0)
        if (Input.GetButtonDown("Jump") && rb.velocity.y == 0)
        {
            // Plays jump sound effect
            audioManager.PlaySFX(audioManager.seahorse_sfx);

            // Applies jump power to the player's vertical velocity
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }

        // Flips the player's direction if moving opposite to the current facing direction
        if (FacingRight && horizontal < 0 || !FacingRight && horizontal > 0)
        {
            // Plays sound effect for character movement
            audioManager.PlaySFX(audioManager.character_movement);

            // Rotates the player 180 degrees on the Y-axis to face the opposite direction
            this.transform.Rotate(0f, 180f, 0f);

            // Updates the FacingRight flag
            FacingRight = !FacingRight;
        }
        
    }
}
