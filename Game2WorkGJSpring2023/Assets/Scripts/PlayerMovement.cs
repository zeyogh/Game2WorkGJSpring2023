using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    private float moveInputX;
    private float moveInputY;

    private Rigidbody2D rb;
    private int inObject = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(inObject == 0){
            moveInputX = Input.GetAxis("Horizontal");
            moveInputY = Input.GetAxis("Vertical");
        
        rb.velocity = new Vector2(moveInputX * speed, moveInputY * speed);
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
         if(collision.gameObject.CompareTag("object"))
        {
            rb.velocity = new Vector2(-1* moveInputX * speed, -1*moveInputY * speed);
            inObject = 1;
            Debug.Log("inObject");

            // while(!Vector2.zero.Equals(rb.velocity)){
            //         Debug.Log("still no control");
            // }

            // inObject = 0;
        }

       
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
