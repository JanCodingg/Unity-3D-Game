using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class HolzText : MonoBehaviour
{
    public TextMeshProUGUI holztext;
    
    
    // Start is called before the first frame update
    private void Awake()
    {
        holztext = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
            holztext.text = "Wood: " + SaveData.currnet.PlayerData.holz + "   Stein: " + SaveData.currnet.PlayerData.stein + "   Eisen: " + SaveData.currnet.PlayerData.eisen;
        
        
    }
}
