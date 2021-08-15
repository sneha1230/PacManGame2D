using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float PlayerSpeed;
    Animator animator;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * PlayerSpeed);
            animator.SetTrigger("Right");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * PlayerSpeed);
            animator.SetTrigger("Left");
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * PlayerSpeed);
            animator.SetTrigger("Up");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * PlayerSpeed);
            animator.SetTrigger("Down");
        }

    }
    

}