using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class MouseLock : MonoBehaviour
{
    //Das haubt GameObject des Players
    public Transform playerBody;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //ist nicht in FixedUpdate weil FixedUpdate länger braucht und dann würde es ruckeln
        CameraController();
    }


    //Mouse Sensitivität 
    public float mouseSensitivity = 100f;
    //Bewegung der Maus auf der y Achse und drehen auf der X Achse
    float yRotation = 0f;

    private void CameraController()
    {
        float mouseX = 0;
        float mouseY = 0;
        if(Input.GetKey(KeyCode.Q))
        {
            Cursor.lockState = CursorLockMode.None;
            
            
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        }

        //Minus um die Y Achse zu invertieren/Richtig zu stellen
        yRotation -= mouseY;
        //Clamp macht das der Wert von yRotation nicht unter -90 oder über 90 geht dadruch kann man sich nicht überdrehen
        yRotation = Mathf.Clamp(yRotation, -90f, 90);
        //Rotiert die X Achse der Camera um den Wert yRotation
        transform.localRotation = Quaternion.Euler(yRotation, 0, 0);
        //Rotiert die Y Achhse des Spieler um den Wert mouseX
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
