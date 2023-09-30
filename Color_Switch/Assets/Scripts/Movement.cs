using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D ball;
    [SerializeField]
    float bouncePower;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ball.velocity = Vector2.up * bouncePower;
        }
    }
}

