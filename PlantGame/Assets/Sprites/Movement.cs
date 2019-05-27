using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rb;
    public float moveHorizontal;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       moveHorizontal=Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);
    }
}
