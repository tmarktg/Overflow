using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreformSpikes : MonoBehaviour
{
    // The position and rotation point from where spikes will be instantiated
    public Transform FirePoint;

    // The spike prefab to instantiate when firing
    public GameObject Spike;

    // Update is called once per frame
    // Checks for the "Fire1" input and spawns a spike at the FirePoint location
    void Update()
    {

         // If the player presses the "Fire1" button (left mouse button)
        if(Input.GetButtonDown("Fire1"))
        {
            // Instantiates a new spike at the FirePoint's position and rotation
            Instantiate(Spike, FirePoint.position, FirePoint.rotation);
        }
    }
}
