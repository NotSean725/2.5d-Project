using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetherMovement : MonoBehaviour
{
    public Transform DestinationSpot;
    public Transform OriginalSpot;
    public float speed;
    public bool Switch = false;

    private void FixedUpdate()
    {
        // For these 2 if statements, it's checking the position of the platform
        if(transform.position == DestinationSpot.position)
        {
            Switch = true;
        }
        if (transform.position == OriginalSpot.position)
        {
            Switch = false;
        }

        // If Switch vbecomes true, it tells the platform to move to its Origin
        if (Switch)
        {
            transform.position = Vector3.MoveTowards(transform.position, OriginalSpot.position, speed);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, DestinationSpot.position, speed);
        }
    }
}
