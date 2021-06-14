using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed ;

   static public float minSpeed = 8f; 
   static public float maxSpeed = 12f;


     void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y); 
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed ); 
        
    }
}
