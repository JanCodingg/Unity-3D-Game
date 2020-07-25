using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MauerUpgrade : MonoBehaviour
{
    public BoxCollider upgradeRadius;
    public BoxCollider WallCollider;

    public int mauerLevel;
    public int maximalLevel;

    private bool InReichweiteZumUpgraden;

    public Canvas resAndButtonAnzeige;
    public Transform Player;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ZeigeBenötigteRessourcen();
    }

    private void ZeigeBenötigteRessourcen()
    {
        if(PlayerController.rayCast.collider == WallCollider && InReichweiteZumUpgraden == true)
        {
            resAndButtonAnzeige.enabled = true;
            //Anzeigen der Ressourcen
            //resAndButtonAnzeige.transform.rotation = Quaternion.RotateTowards(resAndButtonAnzeige.transform.rotation, Player.rotation, 360);
            //Anzeigen des zu drückenden Knopfes

            if(Input.GetKeyDown(KeyCode.Q))
            {
                //Upgrade
            }
        }
        else
        {
            resAndButtonAnzeige.enabled = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            InReichweiteZumUpgraden = true;
        }
        else
        {
            InReichweiteZumUpgraden = false;
        }
    }
}
