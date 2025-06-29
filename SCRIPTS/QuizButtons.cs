using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuizButtons : MonoBehaviour
{

    public GameObject currScreen;
    public GameObject nextScreen;
    public GameObject ohnoScreen;
    public string sceneToLoad;

    public void Correct()
    {
        currScreen.SetActive(false);
        nextScreen.SetActive(true);
    }

    public void Incorrect()
    {
        currScreen.SetActive(false);
        ohnoScreen.SetActive(true);
    }

    public void NextQuestion()
    {
        currScreen.SetActive(false);
        nextScreen.SetActive(true);
    }

    public void Home()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
