using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteinAbbau : MonoBehaviour
{
    public MeshCollider Rock;
    private SteinLebe SteinLeben = new SteinLebe();
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetMouseButton(0))
            {
                if (PlayerController.rayCast.collider == Rock)
                {
                    Debug.Log(SteinLeben.Leben);
                    SteinLeben.Leben -= 1;
                }
            }
        }
    }

    private void Update()
    {
        if (SteinLeben.Leben <= 0)
        {
            SaveData.currnet.stein += 5;
            Destroy(transform.parent.gameObject);
            
        }
    }
}
