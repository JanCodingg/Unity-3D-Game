﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeBaseKlass : MonoBehaviour
{
    private bool canIUpgrade { get; set; }
    public void CanIUpgrade(int currentLVL, int maxLVL, RaycastHit Ray, BoxCollider upgradeCollider, float Upgradedistance)
    {
        if(currentLVL < maxLVL && Ray.collider == upgradeCollider && Upgradedistance <= Ray.distance)
        {
            canIUpgrade = true;
        }
        canIUpgrade = false;
    }

    public void SwitchObject(GameObject[] mauerLevels, int currentLVL)
    {
        
        if(canIUpgrade)
        {
            currentLVL++;
            for (int i = 0; i < mauerLevels.Length; i++)
            {
                mauerLevels[i].SetActive(false);
            }
            mauerLevels[currentLVL].SetActive(true);
        }
    }
}