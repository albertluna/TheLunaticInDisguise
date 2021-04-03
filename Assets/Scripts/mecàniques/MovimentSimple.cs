using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentSimple : MonoBehaviour
{
    int collision; //1 -> NPC, 2 -> Object, 0 -> Nothing
    public bool Mov;
    public bool notesObertes;
    private Rigidbody2D rb;
    public Animator animator;
    public float velocity = 10;

    // Start is called before the first frame update
    void Start()
    {
        //dialeg = FindObjectOfType<tes>();
        rb = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Mov && !notesObertes)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            SpriteRenderer spriteRobin = GetComponent<SpriteRenderer>(); //SpriteRenderer FlipX
            if (verticalInput > 0)
            {
                horizontalInput = verticalInput / 2;
            }
            if (verticalInput < 0)
            {
                horizontalInput = verticalInput / 2;
            }
            if (horizontalInput < 0)
            {
                spriteRobin.flipX = false;
            }

            if (horizontalInput > 0)
            {
                spriteRobin.flipX = true;
            }
            

            animator.SetFloat("Speed", Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput));

            rb.velocity = new Vector2(horizontalInput*velocity, verticalInput*velocity/2); //mirar pujar diagonal

        } else {
            if (Input.GetKey(KeyCode.F))
            {
                Mov = true;
                notesObertes = false;
            }
            rb.velocity = new Vector2(0, 0);
            animator.SetFloat("Speed", 0);
        }
    }
}
