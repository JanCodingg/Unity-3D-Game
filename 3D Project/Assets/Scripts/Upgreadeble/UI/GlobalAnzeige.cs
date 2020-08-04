﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GlobalAnzeige : MonoBehaviour
{
    //Alle 4 Texte für die Mauern
    public GameObject[] MauerText = new GameObject[4];
    //Alle Collider werden hier beschrieben
    public GameObject[][] MauerCollider = new GameObject[4][];
    public GameObject[] Mauer = new GameObject[6];

    // Start is called before the first frame update
    private void Start()
    {

        MauerCollider[0] = UpgradeMauer1.WallLevels;
        MauerCollider[1] = UpgradeMauer2.WallLevels;
        MauerCollider[2] = UpgradeMauer3.WallLevels;
        MauerCollider[3] = UpgradeMauer4.WallLevels;

        Mauer = UpgradeMauer1.WallLevels;

    }
    // Update is called once per frame
    void Update()
    {
        
        for (int i = 0; i < MauerCollider.Length; i++)
        {
            for (int e = 0; e < 6; e++)
            {
                if(PlayerController.rayCast.collider == MauerCollider[i][e].GetComponent<BoxCollider>() && PlayerController.rayCast.distance < 10)
                {
                    
                    MauerText[i].SetActive(true);
                    
                }
                else
                {
                    MauerText[i].SetActive(false);
                }
            }
        }
    }
}