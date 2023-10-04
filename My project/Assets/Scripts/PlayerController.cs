using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveSpeed = 5f;
    private float jumpForce = 5f;
    private float gravity = 9.81f;
    
    private CharacterController controller;
    private Vector3 moveDirection;
    private bool jumping;


    // Start is called before the first frame update
    void Start()
    {
       controller = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        jumping = controller.isGrounded;
        if(jumping )

        float horizontalInput = Input.GetAxis("Horizontal") * moveSpeed;
        float verticalInput = Input.GetAxis("Vertical") * moveSpeed;
        Input.GetButtonDown("Jump") * jumpForce;
    }
}
