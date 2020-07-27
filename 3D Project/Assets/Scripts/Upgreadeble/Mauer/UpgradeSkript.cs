using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UpgradeSkript : UpgradeBaseKlass
{
    public BoxCollider WallCollider;
    private int currentLVL;
    private int maxLVL;
    private float upgradeDistance;
    public GameObject[] WallLevels;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            CanIUpgrade(currentLVL, maxLVL, PlayerController.rayCast, WallCollider, upgradeDistance);
            SwitchObject(WallLevels, currentLVL);
        }
        
        
    }
}
