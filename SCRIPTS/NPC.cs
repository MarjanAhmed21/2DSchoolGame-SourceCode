using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    internal Transform thisTransform;

    public float moveSpeed = 0.2f;


    public Vector2 decisionTime = new Vector2(1, 4);
    internal float decisionTimeCount = 0;

    internal Vector3[] moveDirections = new Vector3[] { Vector3.right, Vector3.left, Vector3.up, Vector3.down, Vector3.zero, Vector3.zero };
    internal int currentMoveDirection;

    private bool isWalking;
    public Animator anim;

    Rigidbody2D rb;

    void Start()
    {
        thisTransform = this.transform;

        decisionTimeCount = Random.Range(decisionTime.x, decisionTime.y);


        ChooseMoveDirection();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = moveDirections[currentMoveDirection];
        float xDir = direction.x;
        float yDir = direction.y;
        thisTransform.position += moveDirections[currentMoveDirection] * Time.deltaTime * moveSpeed;

        if (anim)
        {
            anim.SetFloat("X", xDir);
            anim.SetFloat("Y", yDir);
            isWalking = true;
            anim.SetBool("isMoving", isWalking);
        }

        

        if (decisionTimeCount > 0) decisionTimeCount -= Time.deltaTime;
        else
        {
          
            decisionTimeCount = Random.Range(decisionTime.x, decisionTime.y);
            isWalking = false;
            anim.SetBool("isMoving", isWalking);

            ChooseMoveDirection();
        }

        
    }

    void ChooseMoveDirection()
    {

        currentMoveDirection = Mathf.FloorToInt(Random.Range(0, moveDirections.Length));

    }
   
}
