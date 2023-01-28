using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    private float moveInputX;
    private float moveInputY;

    private Rigidbody2D rb;
    private int canMoveRight = 0;
    private int canMoveLeft = 0;
    private int canMoveUp = 0;
    private int canMoveDown = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        
        moveInputX = Input.GetAxis("Horizontal");
        moveInputY = Input.GetAxis("Vertical");

        if(canMoveRight == 1 && moveInputX > 0){
            rb.velocity = new Vector2(0, moveInputY * speed);
            canMoveLeft = 0;
        }else if(canMoveLeft == 1 && moveInputX < 0){
            rb.velocity = new Vector2(0, moveInputY * speed);
            canMoveRight = 0;
        }else if(canMoveUp== 1 && moveInputY > 0){
            rb.velocity = new Vector2(moveInputX * speed, 0);
            canMoveDown = 0;
        }else if(canMoveDown == 1 && moveInputY < 0){
            rb.velocity = new Vector2(moveInputX * speed, 0);
            canMoveUp = 0;
        }else{
            rb.velocity = new Vector2(moveInputX * speed, moveInputY * speed);
            canMoveRight = 0;
            canMoveLeft = 0;
            canMoveUp = 0;
            canMoveDown = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
         if(collision.gameObject.CompareTag("object"))
        {
            if( moveInputX > 0){
                canMoveRight = 1;
            }
            else if(moveInputX < 0){
                canMoveLeft = 1;
            }
            if(moveInputY > 0){
                canMoveUp = 1;
            }else if(moveInputY < 0){
                canMoveDown = 1;
            }
            

            
        }

       
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
