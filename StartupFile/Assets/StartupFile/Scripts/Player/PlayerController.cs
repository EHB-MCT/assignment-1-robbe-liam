using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private PlayerInput playerInput;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        playerMovement.GroundedCheck();
        playerMovement.SpeedControl();
        playerMovement.AddDragForce();        
    }

    private void FixedUpdate()
    {
        playerMovement.MovePlayer(playerInput.HorizontalInput(), playerInput.VerticalInput());
    }

}
