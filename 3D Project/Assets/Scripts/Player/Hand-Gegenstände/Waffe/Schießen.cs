using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Schießen : MonoBehaviour
{
    public GameObject Projectil;
    public Transform Rotationspunkt;

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && ItemsManager.GegenständeAryStatic[2].activeInHierarchy)
        {
            Feuern(0.2f);
        }
    }

    private void Feuern(float Feuerrate)
    {
        if(Firerate(Feuerrate) == true)
        {
            Quaternion rotation = Rotationspunkt.rotation;
            Instantiate(Projectil, Rotationspunkt.position, Rotationspunkt.rotation);
        }
    }
    private float zwischenspeicher = 0;
    private bool Firerate(float Feuerrate)
    {
        if (zwischenspeicher <= Time.time)
        {
            zwischenspeicher += Feuerrate;
            return true;
        }
        return false;
    }
}
