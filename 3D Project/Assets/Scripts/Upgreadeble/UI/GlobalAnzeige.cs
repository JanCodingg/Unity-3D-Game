using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GlobalAnzeige : MonoBehaviour
{
    //Alle 4 Texte für die Mauern
    public GameObject[] MauerText = new GameObject[4];
    //Alle Collider werden hier beschrieben
    public GameObject[][] MauerCollider;
    //jetziger Text der angezeigt werden soll
    private int Textnummer;
    private int GetroffenerCollider;
    // Start is called before the first frame update
    private void Start()
    {
        MauerCollider = MauerArray.mauerArray;
    }
    // Update is called once per frame
    void Update()
    {
        
        for (int i = 0; i < MauerCollider.Length; i++)
        {
            for (int e = 0; e < MauerCollider[i].Length; e++)
            {
                if(PlayerController.rayCast.collider == MauerCollider[i][e].GetComponent<BoxCollider>() && PlayerController.rayCast.distance < 10)
                {
                    
                    MauerText[i].SetActive(true);
                    Textnummer = i;
                    GetroffenerCollider = e;
                    foreach (GameObject Text in MauerText)
                    {
                        if(Text != MauerText[i])
                        {
                            Text.SetActive(false);
                        }
                    }

                }
                else
                {
                    if (PlayerController.rayCast.collider != MauerCollider[Textnummer][GetroffenerCollider].GetComponent<BoxCollider>() || PlayerController.rayCast.distance > 10)
                    {
                        MauerText[i].SetActive(false);
                    }
                }
            }
        }
    }
}
