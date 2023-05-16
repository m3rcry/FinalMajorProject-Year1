using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movement : MonoBehaviour
{
    Rigidbody2D rb2D;
    Vector2 moveDirection;
    public float walkSpeed;



    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //Rotate();
    }

    void Move()
    {
        //moveDirection.x = Input.GetAxisRaw("Horizontal");
        //moveDirection.y = Input.GetAxisRaw("Vertical");
        //Vector2 moveDirection = new Vector2( Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical")).normalized; 
        //rb2D.MovePosition(rb2D.position + moveDirection * walkSpeed * Time.deltaTime); ---- THIS WORKS BUT JITTERY

        //var horizontalInput = Input.GetAxisRaw("Horizontal");
        //var verticalInput = Input.GetAxisRaw("Vertical");
        //rb2D.velocity = new Vector2(horizontalInput * walkSpeed, rb2D.velocity.x);
        //rb2D.velocity = new Vector2(verticalInput * walkSpeed, rb2D.velocity.y); --- THIS KINDA WORKS

        rb2D.AddForce(new Vector2(Input.GetAxis("Horizontal") * walkSpeed * Time.deltaTime, Input.GetAxis("Vertical") * walkSpeed * Time.deltaTime));
        

    }
    
}
