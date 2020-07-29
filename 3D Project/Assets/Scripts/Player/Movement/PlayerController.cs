using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    private float gravity = -14f;
    public float sprungHöhe = 3f;
    public float verticalVelocity;

    public CharacterController controller;

    Vector3 velocity;

    public static bool hitbool = false;
    public static RaycastHit rayCastLeftClick;
    public static RaycastHit rayCast;

    private int GroundLayermask = 9;
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
        RaycastHit hit;
        Physics.SphereCast(transform.position, 0.4f, new Vector3(0, 3, 0), GroundLayermask, QueryTriggerInteraction.Ignore);
        


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

    void Gravitaiton()
    {
        float zeitInLuft = 0;
        if (controller.isGrounded)
        {
            zeitInLuft = Time.time;
            verticalVelocity = -0.5f;
        }
        else
        {
            float zeit = Time.time - zeitInLuft;
            //Formel für Gravitaion: y = 1/2 * G * Zeit hoch 2
            verticalVelocity += gravity * Time.deltaTime;
        }
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            verticalVelocity = Mathf.Sqrt(sprungHöhe * -2 * gravity);
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
