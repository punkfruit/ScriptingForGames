using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private CharacterController controller;
    private Transform thisTransform;
    private Vector2 movementVector = Vector2.zero;

    private void Start(){
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    private void Update(){
        MoveCharacter();
        KeepCharacterOnAxis();
    }

    private void MoveCharacter(){
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector *= (moveSpeed * Time.deltaTime);
        controller.Move(movementVector);
    }

    private void KeepCharacterOnAxis(){
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
}
