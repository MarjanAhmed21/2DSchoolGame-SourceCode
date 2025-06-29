using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public Animator anim;
    public float moveSpeed;

    public float x, y;
    private bool isRunning;

    private Vector3 moveDir;

   


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        if (x != 0 || y != 0)
        {
            anim.SetFloat("X", x);
            anim.SetFloat("Y", y);
            if (!isRunning)
            {
                isRunning = true;
                anim.SetBool("isMoving", isRunning);
            }
        }
        else
        {
            if (isRunning)
            {
                isRunning = false;
                anim.SetBool("isMoving", isRunning);
                StopMoving();
            }
        }
        moveDir = new Vector3(x, y).normalized;
    }


    void FixedUpdate()
    {
        rb.velocity = moveDir * moveSpeed * Time.deltaTime;
    }

    void StopMoving()
    {
        rb.velocity = Vector3.zero;
    }

}

