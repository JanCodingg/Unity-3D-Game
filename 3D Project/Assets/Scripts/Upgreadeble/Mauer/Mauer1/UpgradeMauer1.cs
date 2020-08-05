using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeMauer1 : UpgradeBaseKlass
{
    private BoxCollider WallCollider;
    private int currentLVL;
    private int maxLVL;
    private float upgradeDistance = 10;
    public static GameObject[] WallLevels;
    public GameObject[] walls;

    private void Awake()
    {
        WallLevels = walls;
    }
    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {

            currentLVL = SaveData.currnet.Mauer1.currentLVL;
            maxLVL = SaveData.currnet.Mauer1.maxLVL;
            WallCollider = WallLevels[currentLVL].GetComponent<BoxCollider>();
            CanIUpgrade(currentLVL, maxLVL, PlayerController.rayCast, WallCollider, upgradeDistance);
            SwitchObject(WallLevels, currentLVL);
            if (canIUpgrade)
            {
                SaveData.currnet.Mauer1.currentLVL++;
            }
            
        }
    }
}
