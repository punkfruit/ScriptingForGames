using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpHeight = 2f;
    public float gravity = -9.81f;
    private CharacterController controller;
    private Vector3 movementVector = Vector3.zero;
    private float verticalVelocity = 0f;

    private void Start(){
        controller = GetComponent<CharacterController>();
    }

    private void Update(){
        MoveCharacter();
        ApplyGravityAndJump();
        KeepCharacterOnAxis();
    }

    private void MoveCharacter(){
        movementVector.x = Input.GetAxis("Horizontal") * moveSpeed;
        controller.Move(movementVector * Time.deltaTime);
    }

    private void ApplyGravityAndJump(){
        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f; // Small value to keep the character grounded.

            if (Input.GetButtonDown("Jump"))
            {
                verticalVelocity = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }
        }
        else
        {
            verticalVelocity += gravity * Time.deltaTime; // Apply gravity when not grounded.
        }

        movementVector.y = verticalVelocity;
        controller.Move(movementVector * Time.deltaTime);
    }

    private void KeepCharacterOnAxis(){
        // Ensure the character stays on the 2D plane by keeping z axis fixed
        var currentPosition = transform.position;
        currentPosition.z = 0f;
        transform.position = currentPosition;
    }
}
