﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteinAbbau : MonoBehaviour
{
    public MeshCollider Rock;
    private SteinLebe SteinLeben = new SteinLebe();
    private void Update()
    {
        if (SteinLeben.Leben <= 0)
        {
            SaveData.currnet.PlayerData.stein += 5;
            Destroy(transform.gameObject);
            
        }
    }

    private void FixedUpdate()
    {
        Abbauen();
    }
    private void Abbauen()
    {
        if (PlayerController.rayCast.distance < 5 && PlayerController.rayCast.collider == Rock && Input.GetMouseButton(0) && ItemsManager.GegenständeAryStatic[1].activeInHierarchy)
        {
            SteinLeben.Leben -= 1;
        }
    }
}
