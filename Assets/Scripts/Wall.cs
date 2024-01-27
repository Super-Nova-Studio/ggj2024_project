using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 direction = Vector3.back;
        rigidBody.velocity = direction * moveSpeed * Time.deltaTime; 
    }
}
