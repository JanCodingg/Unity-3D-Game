using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewController : MonoBehaviour
{
    public float verticalVelocity;
    public float gravity;
    public float jumpForce;
    public float playerSpeed;

    private CharacterController cc;
    private Vector3 moveVector;
    private Vector3 lastMove;

    //private bool runEnabled = true; 
    //private bool strafeEnabled = true;

    void Start()
    {
        gravity = 14.0f;
        jumpForce = 5.0f;
        playerSpeed = 5.0f;
        cc = this.GetComponent<CharacterController>();
    }

    void Update()
    {
        if (cc.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
                Debug.Log("JUMPED!");
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
            moveVector = lastMove;
        }

        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.z = Input.GetAxis("Vertical");

        moveVector *= playerSpeed;
        moveVector.y = verticalVelocity;
        moveVector = transform.TransformDirection(moveVector);
        cc.Move(moveVector * Time.deltaTime);
        lastMove = moveVector;

        /*if (runEnabled) { moveVector.x = Input.GetAxis("Horizontal"); }
        else { moveVector.x = 0f; }
        if (strafeEnabled) { moveVector.z = Input.GetAxis("Vertical"); }
        else { moveVector.z = 0f; }*/
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (!cc.isGrounded && hit.normal.y < 0.1f)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.DrawRay(hit.point, hit.normal, Color.red, 0.75f);
                Debug.Log("WALL JUMPED");
                verticalVelocity = jumpForce;
                //transform.Translate(hit.normal * playerSpeed);
                moveVector = hit.normal * playerSpeed;
            }
        }
        else if (cc.isGrounded)
        {
            Debug.Log("Player grounded");
        }
    }

}
