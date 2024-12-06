using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    // Reference to the player's transform to follow their position
    public Transform Player;

    // Update is called once per frame
    // Adjusts the camera's position to follow the player while maintaining a fixed distance on the Z-axis
    void Update()
    {

        // Sets the camera position to match the player's position with a Z offset of -10 to keep the camera behind the player
       transform.position = Player.transform.position+new Vector3(0,0,-10); 
    }
}
