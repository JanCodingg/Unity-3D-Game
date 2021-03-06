﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForschungsStation : MonoBehaviour
{
    private float sprungHöhe = PlayerController.sprungHöhe;
    private float speed = PlayerController.speed;
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
        
        bool Merker = false;
        if (Input.GetKeyDown(KeyCode.E) && MenüÖffnen == true && Merker == false)
        {
            Merker = true;
            MenüÖffnen = false;
            PlayerController.speed = speed;
            PlayerController.sprungHöhe = sprungHöhe;
        }
        if (PlayerController.rayCast.collider == ColliderStation && PlayerController.rayCast.distance <= 4)
        {
            AnzeigeText.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E) && MenüÖffnen == false)
            {
                if (SaveData.currnet.dataForschung.istEsGebaut == false && ForschungsDaten.Holz <= SaveData.currnet.PlayerData.holz && ForschungsDaten.Stein <= SaveData.currnet.PlayerData.stein)
                {
                    SaveData.currnet.dataForschung.istEsGebaut = true;
                }
                else if(SaveData.currnet.dataForschung.istEsGebaut == true)
                {
                    if (MenüÖffnen == false && Merker == false)
                    {
                        MenüÖffnen = true;
                        PlayerController.speed = 0;
                        PlayerController.sprungHöhe = 0;
                    }
                    else if(MenüÖffnen == true && Merker == false)
                    {
                        MenüÖffnen = false;
                        PlayerController.speed = speed;
                        PlayerController.sprungHöhe = sprungHöhe;
                    }
                }
            }
        }
    }
}
