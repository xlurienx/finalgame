using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; //how fast the player moves
    public float jump; //controls how high the player jumps
    private float move; //idrk what this is for lol
    public Rigidbody2D rb; //where all this force is applied
    public bool Air = false; //to make sure it cant infinately jump in the air
    public Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        //erm
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal"); //"Horizontal" is a pre-made command in unity for games like this. There are some pre-baked commands that unity just understands that you'll see soon

        rb.velocity = new Vector2(speed * move, rb.velocity.y); //actually moves the player left & right after it gets input from the command above

        if (Input.GetKey(KeyCode.W) && Air == false) //this checks for the jump button being pressed AND that youre actually on the ground
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump)); //this makes the player actually jump, it adds Y value to the rigidbody
        }

        if (Air == true) //this checks to see if the player is in the air
        {
            speed = 3;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            Air = false;
            speed = 5;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            Air = true;
        }
    }
   

}