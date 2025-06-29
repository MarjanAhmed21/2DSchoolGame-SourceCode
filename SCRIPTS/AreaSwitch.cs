using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSwitch : MonoBehaviour
{
    public Transform destination;
    GameObject player;
    private bool range;

    // Start is called before the first frame update
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (range && Input.GetKeyDown(KeyCode.E))
        {
            if (Vector2.Distance(player.transform.position, transform.position) > 0.3f)
            {
                player.transform.position = destination.transform.position;
            }
        }
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player")) range = true;
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.CompareTag("Player")) range = false ;
    }
}
