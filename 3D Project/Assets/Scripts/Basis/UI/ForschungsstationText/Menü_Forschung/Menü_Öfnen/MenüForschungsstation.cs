using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenüForschungsstation : MonoBehaviour
{
    public GameObject Menü;

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(ForschungsStation.MenüÖffnen == true)
        {
            Menü.SetActive(true);
        }
        else
        {
            Menü.SetActive(false);
        }
    }
}
