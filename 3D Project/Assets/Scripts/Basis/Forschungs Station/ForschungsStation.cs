using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForschungsStation : MonoBehaviour
{
    public MeshCollider ColliderStation;
    public GameObject AnzeigeText;
    public static bool MenüÖffnen = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerController.rayCast.collider == ColliderStation && PlayerController.rayCast.distance <= 4)
        {
            AnzeigeText.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E) && MenüÖffnen == false)
            {
                if (SaveData.currnet.Forschungsstation.istEsGebaut == false && ForschungsDaten.Holz <= SaveData.currnet.PlayerData.holz && ForschungsDaten.Stein <= SaveData.currnet.PlayerData.stein)
                {
                    SaveData.currnet.Forschungsstation.istEsGebaut = true;
                }
                else if(SaveData.currnet.Forschungsstation.istEsGebaut == true)
                {
                    MenüÖffnen = true;
                    PlayerController.speed = 0;
                }
            }
            else if(Input.GetKeyDown(KeyCode.E))
            {
                MenüÖffnen = false;
                PlayerController.speed = 5;
            }
        }
    }
}
