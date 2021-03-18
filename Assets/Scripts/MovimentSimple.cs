using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentSimple : MonoBehaviour
{
    int collision; //1 -> NPC, 2 -> Object, 0 -> Nothing
    public bool Mov;
    //public tes dialeg;
    // public float us = 0;
    private Rigidbody2D rb;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //dialeg = FindObjectOfType<tes>();
        rb = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Mov == true)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            animator.SetFloat("Speed", Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput));

            rb.velocity = new Vector2(horizontalInput, verticalInput);

            if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
            {
                Vector3 position = this.transform.position;
                position.y -= 0.1f;
                position.x += 0.05f;
                this.transform.position = position;

            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                Vector3 position = this.transform.position;
                position.x += 0.1f;
                this.transform.position = position;

            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                Vector3 position = this.transform.position;
                position.x -= 0.1f;
                this.transform.position = position;
            }

            if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
            {
                Vector3 position = this.transform.position;
                position.y += 0.1f;
                position.x -= 0.05f;
                this.transform.position = position;
            }
        } else
        {
            if (Input.GetKey(KeyCode.F)) Mov = true;
        }
    }
}
