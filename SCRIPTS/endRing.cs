using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endRing : MonoBehaviour
{

    public GameObject Canvas;
    public GameObject ogscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "LastRing")
        {
            Destroy(coll.gameObject);
            Appear();
        }
    }

    public void Appear()
    {
        Canvas.SetActive(true);
        ogscore.SetActive(false);
    }
}
