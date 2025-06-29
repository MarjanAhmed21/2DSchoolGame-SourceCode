using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;
    public Vector2 playerPosition;
    public ValueVector playerStorage;
    bool playerInRange;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            playerStorage.initiateValue = playerPosition;
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player in range");
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player left range");
            playerInRange = false;
        }
    }
}
