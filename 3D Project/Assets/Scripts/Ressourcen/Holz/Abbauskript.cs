using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Abbauskript : MonoBehaviour
{

    public MeshCollider Baum;
    private BaumLeben baumleben = new BaumLeben();
    private int Baumleben = 20;
    public Animator BaumAnimation;

    private void Update()
    {
        
        if(Baumleben <= 0)
        {
            
            SaveData.currnet.PlayerData.holz += 5;
            Destroy(transform.gameObject);
            
        }
        
    }
    private void FixedUpdate()
    {
        Abbauen();
    }

    private void Abbauen()
    {
        if (PlayerController.rayCast.distance < 2 && PlayerController.rayCast.collider == Baum && Input.GetMouseButton(0))
        {
            Baumleben -= 1;
        }
    }
}
