using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class ForschungsstationsText : MonoBehaviour
{
    public MeshCollider Forschungsstation;
    public TextMeshProUGUI Text;
    // Update is called once per frame
    private void Start()
    {
        SaveData.currnet.dataForschung.istEsGebaut = false;
    }
    void Update()
    {
        
        if(PlayerController.rayCast.collider == Forschungsstation && PlayerController.rayCast.distance <= 4)
        {
            if(SaveData.currnet.dataForschung.istEsGebaut == false)
            {
                Text.text = "Press E to build \n Holz: " + ForschungsDaten.Holz + "Stein: " + ForschungsDaten.Stein;
            }
            else
            {
                Text.text = "Press E";
            }
        }
        else
        {
            Text.text = "";
        }
    }
}
