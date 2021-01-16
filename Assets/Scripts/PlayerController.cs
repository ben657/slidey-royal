using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 MoveInput { get; set; }
    public Vector2 LookInput { get; set; }

    public float runSpeed = 1.0f;
    public float lookSpeed = 1.0f;
    public float pitchLimit = 45.0f;

    [Header("Parts")]
    public Transform head;

    Rigidbody body;

    float yaw = 0.0f;
    float pitch = 0.0f;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.AngleAxis(yaw, transform.up);
        head.localRotation = Quaternion.AngleAxis(pitch, -Vector3.right);
    }

    private void FixedUpdate()
    {
        Vector3 direction = new Vector3(MoveInput.x, 0.0f, MoveInput.y);
        body.AddForce(transform.TransformDirection(direction) * runSpeed);

        yaw += lookSpeed * LookInput.x;
        yaw %= 360.0f;

        pitch += lookSpeed * LookInput.y;
        pitch = Mathf.Clamp(pitch, -pitchLimit, pitchLimit);
    }
}
