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
        Debug.Log(GroundCheck());
    }

    bool GroundCheck()
    {
        RaycastHit hit;
        if (Physics.SphereCast(transform.position + new Vector3(0, 0, 0), 0.4f, new Vector3(0, -0.85f, 0), out hit, 10f))
        {
            Debug.Log(hit.collider.gameObject.layer);
            Debug.Log(hit.collider.name);
            if(hit.collider.gameObject.layer == 9)
            {

                return true;
            }
        }
        return false;
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position + new Vector3(0, -0.85f, 0), 0.4f);
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
        if (GroundCheck())
        {
            zeitInLuft = Time.time;
            verticalVelocity = -0.5f;
        }
        else
        {
            float zeit = Time.time - zeitInLuft;
            //Formel für Gravitaion: y = 1/2 * G * Zeit hoch 2
            verticalVelocity += gravity * Time.deltaTime * zeit;
        }
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && GroundCheck())
        {
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
