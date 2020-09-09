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


    public PlayerData PlayerData = new PlayerData();
    public Mauer Mauer1 = new Mauer();
    public Mauer Mauer2 = new Mauer();
    public Mauer Mauer3 = new Mauer();
    public Mauer Mauer4 = new Mauer();
    public DataForschung dataForschung = new DataForschung();
    
    

}
