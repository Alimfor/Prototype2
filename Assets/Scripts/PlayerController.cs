using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float jumpForce;
    public float gravityModifier = 1;
    public bool isOnGround = true;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space) || !isOnGround) return;
        
        _rigidbody.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
        isOnGround = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
