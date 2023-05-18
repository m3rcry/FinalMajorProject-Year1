using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
* Fix this script so you can move the player - Go through each line carefully. 
* Your player will need a Rigidbody 2D to work
* Add a Box collider2D to your player too. 
*/
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
        Rotate();
    }

    void Move()
    {
        //moveDirection.x = Input.GetAxisRaw("Horizontal");
        //moveDirection.y = Input.GetAxisRaw("Vertical");
        Vector2 moveDirection = new Vector2( Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical")).normalized; 
        rb2D.MovePosition(rb2D.position + moveDirection * walkSpeed * Time.deltaTime);
    }

    void Rotate(){
        Vector2 lookDir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
    }
}
