using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButton : MonoBehaviour
{
    public static bool Laden = false;
    public void saveButton()
    {
        SerializationManager.Save("PlayerData", SaveData.currnet);
        
    }
    public void loadButton()
    {
        SaveData.currnet = (SaveData)SerializationManager.Load("PlayerData");
        Laden = true;
    }
}
