using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MauerArray : MonoBehaviour
{
    public GameObject[] Mauer1 = new GameObject[6];
    public GameObject[] Mauer2 = new GameObject[6];
    public GameObject[] Mauer3 = new GameObject[6];
    public GameObject[] Mauer4 = new GameObject[6];

    public static GameObject[][] mauerArray = new GameObject[4][];
    private void Awake()
    {
        
        mauerArray[0] = Mauer1;
        mauerArray[1] = Mauer2;
        mauerArray[2] = Mauer3;
        mauerArray[3] = Mauer4;
    }
}
