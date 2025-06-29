using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesSwitch : MonoBehaviour
{
    public GameObject clothesOn;
    public GameObject penGot;
    public RuntimeAnimatorController cont;
    // Start is called before the first frame update
    public void Change()
    {
        Animator anim = this.GetComponent<Animator>();
        anim.runtimeAnimatorController = cont;
        clothesOn.SetActive(true);
    }

    public void GetPen()
    {
       
        penGot.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
