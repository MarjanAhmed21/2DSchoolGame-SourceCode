using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameTrans : MonoBehaviour
{
    private bool range;
    public string sceneToLoad;


    void Update()
    {
        if (range && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(sceneToLoad);
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
