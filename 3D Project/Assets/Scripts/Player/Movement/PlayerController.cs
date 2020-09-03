using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variablen für die Bewegung
    public static float speed = 5;
    private float gravity = 16f;
    public static float sprungHöhe = 3f;
    public float verticalVelocity;

    public CharacterController controller;

    Vector3 velocity;

    //Raycast für das Fadenkreuz
    public static bool hitbool = false;
    public static RaycastHit rayCastLeftClick;
    public static RaycastHit rayCast;

    //Variablen für GroundCheck
    public LayerMask groundmask;
    public float shereRadius = 0.3f;
    public Transform groundCheck;

    void Start()
    {
        //groundCheck.Find("SpherePos").GetComponentInChildren<Transform>();
        groundmask = LayerMask.GetMask("Ground");
        //shereRadius = controller.radius - 0.2f;

    }
    // Update is called once per frame
    void Update()
    {
       
        velocity = Vector3.zero;
        Gravitaiton();
        Jump();
        TastaturControlle();
        Raycast();
        
    }

    bool GroundCheck()
    {
        if(Physics.CheckSphere(groundCheck.position, shereRadius, groundmask))
        {
            return true;
        }
        return false;
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheck.position, shereRadius);
    }

    void TastaturControlle()
    {

        velocity.x = Input.GetAxis("Horizontal");
        velocity.z = Input.GetAxis("Vertical");

        velocity *= speed;
        velocity.y = verticalVelocity;
        velocity = transform.TransformDirection(velocity);
        controller.Move(velocity * Time.deltaTime);
        

    }
    private float zeitInLuft;
    private float zeit;
    void Gravitaiton()
    {
        if (GroundCheck() == true && verticalVelocity < 0)
        {
            zeitInLuft = Time.time;
            verticalVelocity = -0.1f;
        }
        else
        {
            zeit = Time.time - zeitInLuft;
            //Formel für Gravitaion: y = 1/2 * G * Zeit hoch 2
            verticalVelocity += gravity * Time.deltaTime * zeit * -1;
        }
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && GroundCheck() == true)
        {
            zeitInLuft = Time.time;
            verticalVelocity = -0.1f;
            verticalVelocity = Mathf.Sqrt(sprungHöhe * gravity - 2);
        }
    }

    void Raycast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out rayCastLeftClick))
            {
                hitbool = true;

            }
            else
            {
                hitbool = false;
            }
        }
        Physics.Raycast(ray, out rayCast);

        
    }
 
}
