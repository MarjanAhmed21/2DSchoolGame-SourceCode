using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ringcollect : MonoBehaviour
{

    int totalRings;
    int ringsCollected;
    public TextMeshProUGUI score;
    public GameObject ogscore;
    public TextMeshProUGUI score2;
    public GameObject Canvas;

    private void Start()
    {
        ringsCollected = 0;
        totalRings = 10;
    }

    void Update()
    {
        string uiString = ringsCollected + "/" + totalRings;
        score.text = uiString;
        score2.text = uiString;
    }


    // Update is called once per frame
     void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Ring")
        {
            Destroy(coll.gameObject);
            ringsCollected++;
        }

        if (coll.gameObject.tag == "LastRing")
        {
            ringsCollected++;
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