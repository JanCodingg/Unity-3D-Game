using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaumLeben
{
    public static int BaumeAbbaueLevel = 0;
    internal int Leben = 100;
    public void Lebenbestimmen()
    {
        
        switch (BaumeAbbaueLevel)
        {
            case 0:
                Leben = 100;
                break;
            case 1:
                Leben = 90;
                break;
            case 2:
                Leben = 80;
                break;
            case 3:
                Leben = 70;
                break;
            case 4:
                Leben = 60;
                break;
            case 5:
                Leben = 50;
                break;
            case 6:
                Leben = 40;
                break;
            case 7:
                Leben = 30;
                break;
            default:
                Leben = 100;
                break;
        }

    }
   
    
}
