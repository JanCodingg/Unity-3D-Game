using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextFürUpgradebare : MonoBehaviour
{
    public TextMeshProUGUI Text;
    private int currentLVL;
    public int WelcheMauer;
    // Start is called before the first frame update
    void Start()
    {
        Text.GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        switch(WelcheMauer)
        {
            case 0:
                currentLVL = SaveData.currnet.Mauer1.currentLVL;
                break;
            case 1:
                currentLVL = SaveData.currnet.Mauer2.currentLVL;
                break;
            case 2:
                currentLVL = SaveData.currnet.Mauer3.currentLVL;
                break;
            case 3:
                currentLVL = SaveData.currnet.Mauer4.currentLVL;
                break;
            default:
                currentLVL = 6;
                break;
        }
        
        Text.text = "Level: " + currentLVL + "\n Upgrade for: \n Holz " + Stats.RessourceMauerArr[currentLVL, 0] + " Stein " + Stats.RessourceMauerArr[currentLVL, 1] + " Eisen " + Stats.RessourceMauerArr[currentLVL, 2];
    }
}
