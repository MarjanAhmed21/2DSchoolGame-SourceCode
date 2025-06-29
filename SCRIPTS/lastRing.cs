using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lastRing : MonoBehaviour
{
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Barrier")
        {
            Destroy(this);
            Appear();
        }
    }

     void Appear()
    {
        Canvas.SetActive(true);
    }
}
