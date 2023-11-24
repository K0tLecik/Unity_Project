using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFalling : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject cube;

    void Start()
    {
        rb = cube.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.mass = 2;
        }
    }
}
