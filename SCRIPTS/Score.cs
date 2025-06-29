using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public GameObject text;
    public GameObject text2;
    public TextMeshProUGUI score;
    public TextMeshProUGUI score2;
    public int totalScore = 10;
    int points;

    void Start()
    {
        points = 0;
    }

    public void Appear()
    {
        text.SetActive(true);
        text2.SetActive(true);
    }

    public void Disppear()
    {
        text.SetActive(false);
    }

    void Update()
    {
        string uiString = points + "/" + totalScore;
        score.text = uiString;
        score2.text = uiString;
    }

    public void Correct()
    {
        points++;
    }
}
