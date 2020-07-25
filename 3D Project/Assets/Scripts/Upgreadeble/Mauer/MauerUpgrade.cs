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

    public Transform Player;

    public static bool allesgut = false;

    
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        allesgut = ZeigeBenötigteRessourcen();
    }

    public bool ZeigeBenötigteRessourcen()
    {
        
        if(PlayerController.rayCast.collider == WallCollider && InReichweiteZumUpgraden == true)
        {
            
            return true;
        }
        return false;
        
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
