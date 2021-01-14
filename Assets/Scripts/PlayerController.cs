using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 MoveInput { get; set; }
    public Vector2 RotateInput { get; set; }

    public float runSpeed = 1.0f;
    public float lookSpeed = 1.0f;

    Rigidbody body;

    Vector3 lookVector = Vector3.zero;

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

        lookVector = Quaternion.AngleAxis(lookSpeed * Time.fixedDeltaTime, transform.up) * lookVector;
    }
}
