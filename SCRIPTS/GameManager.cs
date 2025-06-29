using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    private static GameManager gameManager;
    // Start is called before the first frame update
    private void Awake()
    {
        if(gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(gameManager);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
