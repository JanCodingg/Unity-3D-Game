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
        SaveData.currnet = (SaveData)SerializationManager.Load(Application.persistentDataPath + "/saves/Save.save");
    }

    // Update is called once per frame
    void Update()
    {
        
        holztext.text = "Wood: " + SaveData.currnet.DATA.holz + "   Stein: " + SaveData.currnet.DATA.stein + "   Eisen: " + SaveData.currnet.DATA.eisen;
    }
}
