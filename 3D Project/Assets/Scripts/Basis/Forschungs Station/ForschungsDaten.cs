using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForschungsDaten : MonoBehaviour
{
    //Forschungsstation freischalten
    public static int Holz = 200;
    public static int Stein = 300;



    //Verbessern der Abbau fähigkeit : HOLZ
    //{ 100 Holz, 50 Stein, 10 Eisen }
    public int[,,] AbbauHOLZ = new int[,,]
    { 
        { 
            { 250, 200, 0 }, { 500, 600, 100 } ,{ 1700, 1000, 500 }
        } 
    };

    //Verbessern der Abbau fähigkeit : STEIN
    //{ 100 Holz, 50 Stein, 10 Eisen }
    public int[,,] AbbauStein = new int[,,] 
    {
        { 
            { 250, 200, 0 }, { 500, 600, 100 }, { 1700, 1000, 500 }
        } 
    };


}
