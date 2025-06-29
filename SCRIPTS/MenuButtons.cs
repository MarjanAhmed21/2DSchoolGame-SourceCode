using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject current;
    public GameObject next;
    public GameObject camera;
    public string sceneToLoad;
    public GameObject clothesOn;
    public GameObject pensObtained;
    public GameObject waitfam;

    GameObject player;
    private bool range;
    // Start is called before the first frame update


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Opening()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void Level1()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }

    public void HowToPlay()
    {
        camera.transform.position = new Vector3(21, 0, -1);
    }

    public void Menu()
    {
        camera.transform.position = new Vector3(0, 0, -1);
    }

    public void Next()
    {
        next.SetActive(true);
        current.SetActive(false);
    }

    void Update()
    {
        if (range && Input.GetKeyDown(KeyCode.E))
        {
            waitfam.SetActive(true);
        }
        if (clothesOn.activeInHierarchy && pensObtained.activeInHierarchy && range && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player")) range = true;
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.CompareTag("Player")) range = false;
    }
}
