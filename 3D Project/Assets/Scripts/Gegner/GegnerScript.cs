using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GegnerScript : MonoBehaviour
{
    public GameObject Patrone;
    


    

    private void OnCollisonEnter(Collider other)
    {
        Debug.Log("Triggert");
        if(other.gameObject == Patrone.gameObject)
        {
            Destroy(this.gameObject);
        }
    }
}
