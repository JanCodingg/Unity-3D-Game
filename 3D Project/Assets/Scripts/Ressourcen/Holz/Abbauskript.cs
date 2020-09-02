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
  

   
    private void FixedUpdate()
    {
        Abbauen();
        StartCoroutine(PlayAnimation());
    }

    private void Abbauen()
    {
        Debug.Log(Baumleben);
        if (PlayerController.rayCast.distance < 2 && PlayerController.rayCast.collider == Baum && Input.GetMouseButton(0))
        {
            Baumleben -= 1;
        }
    }

    private IEnumerator PlayAnimation()
    {
        if (Baumleben <= 0)
        {
            string BaumName = BaumAnimation.name.Remove(7);
            Debug.Log(BaumName);
            if(BaumName == "Tree_02")
            {
                BaumAnimation.SetBool("Baum_fällt_Aktivieren", true);
                Destroy(Baum);
                yield return new WaitForSeconds(9.5f);
                SaveData.currnet.PlayerData.holz += 5;
                Destroy(transform.gameObject);
            }
            else
            {
                //Setzt den bool um den Baum fallen zu lassen und zerstört den Meshcollider des Baumes

                BaumAnimation.SetBool("Aktivier_Baumfällt", true);
                Destroy(Baum);
                //Wartet 9s 
                yield return new WaitForSeconds(9f);
                SaveData.currnet.PlayerData.holz += 5;
                Destroy(transform.gameObject);
            }
        }
    }
}
