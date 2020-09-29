using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatroneBewegen : MonoBehaviour
{
    private void Start()
    {
        transform.Rotate(transform.rotation.x + 90, transform.rotation.y, transform.rotation.z);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.up * Time.deltaTime * 15, Space.Self);
    }
}
