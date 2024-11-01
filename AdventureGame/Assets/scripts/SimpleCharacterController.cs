using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;
    private CharacterController controller;
    private Transform thisTransform;
    private Vector2 movementVector = Vector2.zero;

    public SimpleFloatData StaminaData;
    public SimpleImageBehaviour staminaBar;

    private void Start(){
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    private void Update(){
        MoveCharacter();
        KeepCharacterOnAxis();
        ApplyGravity();
    }

    private void MoveCharacter(){
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector *= (moveSpeed * Time.deltaTime);
        
        controller.Move(movementVector);

        if(Input.GetButtonDown("Jump")){
            movementVector.y = Mathf.Sqrt(jumpForce * -2f * gravity);
            //Debug.Log("jumpedddd");
            StaminaData.UpdateValue(-0.3f);
            staminaBar.UpdateWithFloatData();
        }
    }

    private void ApplyGravity(){
        if(!controller.isGrounded){
            movementVector.y += gravity * Time.deltaTime;
        }
        else{
            movementVector.y = 0;
        }
    }


    private void KeepCharacterOnAxis(){
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
}
