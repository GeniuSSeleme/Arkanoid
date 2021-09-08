using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{

    public float speed = 100.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get Horizental Input
        float h = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;

    }
}
