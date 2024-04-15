using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movRunner : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
