using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class SawRotation : MonoBehaviour
{
    public float speed = 1f;
    void Update()
    {
        transform.Rotate(0, 0, -360 * speed * Time.deltaTime);
    }
}
