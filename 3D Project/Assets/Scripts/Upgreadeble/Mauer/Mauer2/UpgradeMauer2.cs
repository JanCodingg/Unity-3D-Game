using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeMauer2 : UpgradeBaseKlass
{
    private BoxCollider WallCollider;
    private int currentLVL;
    private int maxLVL;
    private float upgradeDistance = 10;
    public static GameObject[] WallLevels;
    public GameObject[] walls;
    // Update is called once per frame
    private void Start()
    {
        WallLevels = walls;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {

            currentLVL = SaveData.currnet.Mauer2.currentLVL;
            maxLVL = SaveData.currnet.Mauer2.maxLVL;
            WallCollider = WallLevels[currentLVL].GetComponent<BoxCollider>();
            CanIUpgrade(currentLVL, maxLVL, PlayerController.rayCast, WallCollider, upgradeDistance);
            SwitchObject(WallLevels, currentLVL);
            if (canIUpgrade)
            {
                SaveData.currnet.Mauer2.currentLVL++;
            }
        }
    }
}
