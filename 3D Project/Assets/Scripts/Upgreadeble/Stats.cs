using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    
    public static readonly int[] MaxHealthMauerArr = new int[] { 100, 200, 350, 500, 770, 1000};
    //Ressourcen Reihenfolge: Holz, Stein, Eisen
    public static readonly int[,] RessourceMauerArr = new int[5, 3] { 
    //Holz, Stein, Eisen
        {30, 15, 0 },
        {60, 30, 0 },
        {120, 60, 0 },
        {250, 150, 30 },
        {500, 300, 100 }
    };

}
