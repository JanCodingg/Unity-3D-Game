using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class ForschungsstationsText : MonoBehaviour
{
    public TextMeshProUGUI Text;
    // Update is called once per frame
    void Update()
    {
        if(SaveData.currnet.Forschungsstation.istEsGebaut == false)
        {
            Text.text = "Press E to bouild \n Holz: " + ForschungsDaten.Holz + "Stein: " + ForschungsDaten.Stein;
        }
    }
}
