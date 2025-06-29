using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInGame : MonoBehaviour
{
    public GameObject SchoolUniformItem;
    public GameObject clothesShopUI;
    public GameObject canvas;
    public GameObject rings;
    public GameObject text;
    public GameObject text2;


    public GameObject player;
    private bool range;


    public void Wear()
    {
    }

    public void Obtain()
    {
        SchoolUniformItem.SetActive(false);
    }


    public void Appear()
    {
        rings.SetActive(true);
        text.SetActive(true);
        text2.SetActive(true);
    }


    public void CloseMenu()
    {
        canvas.SetActive(false);
    }


    void Update()
    {
        if (range && Input.GetKeyDown(KeyCode.E))
        {
            canvas.SetActive(true);
            clothesShopUI.SetActive(true);
        }
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player")) range = true;
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.CompareTag("Player")) range = false;
    }

}
