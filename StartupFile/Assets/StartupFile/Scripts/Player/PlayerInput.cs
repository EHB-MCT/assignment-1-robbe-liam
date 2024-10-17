using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{ 
    public float HorizontalInput()
    {
        return Input.GetAxisRaw("Horizontal");
    }

    public float VerticalInput()
    {
        return Input.GetAxisRaw("Vertical");
    }   
}
