using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 MoveInput { get; set; }

    public float runSpeed = 1.0f;

    Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        body.AddForce(new Vector3(MoveInput.x, 0.0f, MoveInput.y) * runSpeed);
    }
}
