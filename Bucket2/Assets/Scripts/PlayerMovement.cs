using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 6f;
    public float moveMultiplier = 10f;

    float horizontalMovement;
    float verticalMovement;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start() 
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update() 
    {
        MyInput();
    }

    void MyInput()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");

        moveDirection = transform.forward * verticalMovement + transform.right * horizontalMovement;
    }

    private void FixedUpdate() //in fixed update because it has the frequency of the physics system
    {
        MovePlayer();    
    }

    void MovePlayer()
    {
        rb.AddForce(moveDirection.normalized * moveSpeed * moveMultiplier, ForceMode.Acceleration);
    }   

}
