using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButton : MonoBehaviour
{
    public void saveButton()
    {
        SerializationManager.Save("PlayerData", SaveData.currnet);
        Debug.Log(SaveData.currnet.holz);
    }
    public void loadButton()
    {
        SaveData.currnet = (SaveData)SerializationManager.Load("PlayerData");
        Debug.Log(SaveData.currnet.holz);
    }
}
