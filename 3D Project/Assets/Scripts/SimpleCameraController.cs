using System;
using UnityEngine;

namespace UnityTemplateProjects
{
    public class SimpleCameraController : MonoBehaviour
    {
        class CameraState
        {
            public float yaw;
            public float pitch;
            public float roll;
          

            public void SetFromTransform(Transform t)
            {
                pitch = t.eulerAngles.x;
                yaw = t.eulerAngles.y;
                roll = t.eulerAngles.z;
                
            }

            public void LerpTowards(CameraState target)
            {
                yaw = target.yaw;
                pitch = target.pitch;
                roll = target.roll;
            }

            public void UpdateTransform(Transform t)
            {
                t.eulerAngles = new Vector3(pitch, yaw, roll);
               
            }
        }
        
        CameraState m_TargetCameraState = new CameraState();
        CameraState m_InterpolatingCameraState = new CameraState();

       
        

       

        
        

        void OnEnable()
        {
            m_TargetCameraState.SetFromTransform(transform);
            m_InterpolatingCameraState.SetFromTransform(transform);
        }

 
        
        void Update()
        {
            
            // Hide and lock cursor when right mouse button pressed
            if (Input.GetMouseButtonDown(1))
            {
                Cursor.lockState = CursorLockMode.Locked;
            }

            // Unlock and show cursor when right mouse button released
            if (Input.GetMouseButtonUp(1))
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            
            // Rotation
            if (Input.GetMouseButton(1))
            {
                
                //Variable mit den Maus Daten. Am Ende noch eine abfrage ob man die Y Achse invertieren möchte
                Vector2 mouseMovement = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
                //gibt einen Wert auf der Y Achse zurück je nach dem wie schnell man die Maus bewegt
                //float mouseSensitivityFactor = mouseSensitivitycurve.Evaluate(mouseMovement.magnitude);
                
                //Setzt die rotation auf der x und y achse (Wichtig nur die beiden Vaiablen) fest
                m_TargetCameraState.yaw += mouseMovement.x;
                m_TargetCameraState.pitch += mouseMovement.y;
            }

            m_InterpolatingCameraState.LerpTowards(m_TargetCameraState);

            m_InterpolatingCameraState.UpdateTransform(transform);
        }
    }

}