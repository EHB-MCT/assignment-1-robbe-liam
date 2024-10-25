using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public float groundDrag;

    [Space(10)]
    [Header("Ground check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    public bool isGrounded;

    [Space(10)]
    [Header("Player")]
    public Transform orientation;
    Vector3 moveDirection;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void MovePlayer(float horizontalInput, float verticalInput)
    {

    }

    public void GroundedCheck()
    {

    }

    public void AddDragForce() 
    {

    }

    public void SpeedControl()
    {

    }

}
