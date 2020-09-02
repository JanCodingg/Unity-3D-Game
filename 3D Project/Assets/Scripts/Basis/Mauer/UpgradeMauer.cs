using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeMauer : UpgradeBaseKlass
{
    private BoxCollider WallCollider;
    private int currentLVL = 0;
    private int maxLVL;
    private float upgradeDistance = 10;
    public int WelcheMauer;
    

    
    void Update()
    {
        switch (WelcheMauer)
        {
            case 0:
                currentLVL = SaveData.currnet.Mauer1.currentLVL;
                maxLVL = SaveData.currnet.Mauer1.maxLVL;
                break;
            case 1:
                currentLVL = SaveData.currnet.Mauer2.currentLVL;
                maxLVL = SaveData.currnet.Mauer2.maxLVL;
                break;
            case 2:
                currentLVL = SaveData.currnet.Mauer3.currentLVL;
                maxLVL = SaveData.currnet.Mauer3.maxLVL;
                break;
            case 3:
                currentLVL = SaveData.currnet.Mauer4.currentLVL;
                maxLVL = SaveData.currnet.Mauer4.maxLVL;
                break;
        }
        SwitchObject(MauerArray.mauerArray[WelcheMauer], currentLVL);

        if (Input.GetKeyDown(KeyCode.E))
        {
            WallCollider = MauerArray.mauerArray[WelcheMauer][currentLVL].GetComponent<BoxCollider>();
            CanIUpgrade(currentLVL, maxLVL, PlayerController.rayCast, WallCollider, upgradeDistance);
            //SwitchObject(MauerArray.mauerArray[WelcheMauer], currentLVL);
            if (canIUpgrade)
            {
                
                switch (WelcheMauer)
                {
                    case 0:
                        ++SaveData.currnet.Mauer1.currentLVL;
                        Debug.Log(SaveData.currnet.Mauer1.currentLVL);
                        break;
                    case 1:
                        ++SaveData.currnet.Mauer2.currentLVL;
                        break;
                    case 2:
                        ++SaveData.currnet.Mauer3.currentLVL;
                        break;
                    case 3:
                        ++SaveData.currnet.Mauer4.currentLVL;
                        break;
                }
                SaveData.currnet.PlayerData.holz -= Stats.RessourceMauerArr[currentLVL, 0];
                SaveData.currnet.PlayerData.stein -= Stats.RessourceMauerArr[currentLVL, 1];
                SaveData.currnet.PlayerData.eisen -= Stats.RessourceMauerArr[currentLVL, 2];

            }
            
        }
    }
}
