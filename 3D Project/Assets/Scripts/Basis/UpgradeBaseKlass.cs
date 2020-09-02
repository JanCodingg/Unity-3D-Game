using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeBaseKlass : MonoBehaviour
{
    internal bool canIUpgrade { get; set; }
    public void CanIUpgrade(int currentLVL, int maxLVL, RaycastHit Ray, BoxCollider upgradeCollider, float Upgradedistance)
    {
        
        if(currentLVL < maxLVL && Ray.collider == upgradeCollider && Upgradedistance >= Ray.distance && SaveData.currnet.PlayerData.holz >= Stats.RessourceMauerArr[currentLVL, 0] && SaveData.currnet.PlayerData.stein >= Stats.RessourceMauerArr[currentLVL, 1] && SaveData.currnet.PlayerData.eisen >= Stats.RessourceMauerArr[currentLVL, 2])
        {
            canIUpgrade = true;
        }
        else
        {
            canIUpgrade = false;
        }
    }

    public void SwitchObject(GameObject[] mauerLevels, int currentLVL)
    {
            for (int i = 0; i < mauerLevels.Length; i++)
            {
                mauerLevels[i].SetActive(false);
            }
            mauerLevels[currentLVL].SetActive(true);
    }
}
