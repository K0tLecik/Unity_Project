using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public float x = 0, y = 1;
    private float yPoss;

    void Update()
    {
        if (player.position.y + y >= -1)
        {
            yPoss = player.position.y + y;
        }
        else
        {
            yPoss = -1;
        }
        transform.position = new Vector3(player.position.x + x, yPoss, transform.position.z);
    }
}
