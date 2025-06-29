using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMoveLeft : MonoBehaviour
{
    public Vector3 initialSpawnPosition;
    public float moveSpeed = 10;
    public bool movingLeft;


    void Start()
    {
        initialSpawnPosition = transform.position;
        movingLeft = true;


    }
    void Update()
    {


        if (movingLeft)
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);

            
        }
        
    }
}
