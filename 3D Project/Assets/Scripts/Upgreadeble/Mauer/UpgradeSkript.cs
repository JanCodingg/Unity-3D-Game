using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UpgradeSkript : UpgradeBaseKlass
{
    public BoxCollider WallCollider;
    private int currentLVL;
    private int maxLVL;
    private float upgradeDistance = 10;
    public GameObject[] WallLevels;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.E))
        {
            
            currentLVL = SaveData.currnet.Mauer1.currentLVL;
            maxLVL = SaveData.currnet.Mauer1.maxLVL;
            WallCollider = WallLevels[currentLVL].GetComponent<BoxCollider>();
            CanIUpgrade(currentLVL, maxLVL, PlayerController.rayCast, WallCollider, upgradeDistance);
            SwitchObject(WallLevels, currentLVL);
            if(currentLVL < maxLVL)
            {
                SaveData.currnet.Mauer1.currentLVL++;
            }
        }
        Debug.Log(SaveData.currnet.Mauer1.currentLVL);
    }
}
