using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class RotateToCamera : MonoBehaviour
{
    private Camera camera;
    
    public Canvas canvas;

    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        
        canvas.GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(MauerUpgrade.allesgut == true)
        {
            MoveAndRotate();
            
        }
        else
        {
            canvas.enabled = false;
        }
    }

    private void MoveAndRotate()
    {
        canvas.enabled = true;
        transform.LookAt(transform.position + camera.transform.rotation * Vector3.back, camera.transform.rotation * Vector3.up);
        Vector3 Crosshairpos = new Vector3(PlayerController.rayCast.point.x, PlayerController.rayCast.point.y, PlayerController.rayCast.point.z);
        transform.position = Vector3.MoveTowards(transform.position, Crosshairpos, 0.5f);
    }
}
