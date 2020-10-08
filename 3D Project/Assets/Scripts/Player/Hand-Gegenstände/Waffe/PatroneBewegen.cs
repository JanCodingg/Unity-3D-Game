using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PatroneBewegen : MonoBehaviour
{
    public GameObject Player;
    private int timeSinceBeginning = 0;
    private void Start()
    {
        transform.Rotate(transform.rotation.x + 90, transform.rotation.y, transform.rotation.z);
        timeSinceBeginning = (int)Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.up * Time.deltaTime * 15, Space.Self);

        if (Time.time - timeSinceBeginning >= 20)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject != Player)
        {
            Destroy(this.gameObject);
        }
        
    }
}
