﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Abbauskript : MonoBehaviour
{
    public MeshCollider Tree;
    private BaumLeben baumleben = new BaumLeben();
    

    private void Update()
    {
        
        if(baumleben.Leben <= 0)
        {
            SaveData.currnet.PlayerData.holz += 5;
            Destroy(transform.gameObject);
            
        }
        
    }
    private void FixedUpdate()
    {
        Abbauen();
    }

    private void Abbauen()
    {
        if (PlayerController.rayCast.distance < 2 && PlayerController.rayCast.collider == Tree && Input.GetMouseButton(0))
        {
            baumleben.Leben -= 1;
        }
    }
}
