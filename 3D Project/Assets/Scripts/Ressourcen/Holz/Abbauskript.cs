using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Abbauskript : MonoBehaviour
{
    public MeshCollider Tree;
    private BaumLeben baumleben = new BaumLeben();
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetMouseButton(0))
            {
                
                if (PlayerController.rayCast.collider == Tree)
                {
                    //Debug.Log(baumleben.Leben);
                    baumleben.Leben -= 1;
                }
            }
        }
    }

    private void Update()
    {
        if(baumleben.Leben <= 0)
        {
            SaveData.currnet.holz += 5;
            Destroy(transform.parent.gameObject);
            
        }
    }
}
