using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Wall : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
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
