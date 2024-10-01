using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    private PlayerControls controls; // Ref to Input Actions
    private Vector2 movementInput; // Store movement

    private void Awake()
    {
        controls = new PlayerControls(); // Instantiate the PlayerControls class
        controls.Enable(); // Enable controls
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newMovementInput = controls.Player.Move.ReadValue<Vector2>(); // Poll move input every frame

        if (newMovementInput != Vector2.zero)
        {
            movementInput = newMovementInput;
            Debug.Log("Move Input: " + movementInput);
        }
    }
}
