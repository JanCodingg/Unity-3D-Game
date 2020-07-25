using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classen welche gespeichert werden sollen müssen mit Serializable gekennzeichnet werden
[System.Serializable]
public class SaveData
{
    private static SaveData _current;
    public static SaveData currnet
    {
        get
        {
            if(_current == null)
            {
                _current = new SaveData();
            }
            return _current;
        }
        set
        {
            if(value != null)
            {
                _current = value;
            }
        }
    }

    public int holz = 0;
    public int stein = 0;
    public int eisen = 0;


}
