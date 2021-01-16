using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using MLAPI;

public class PlayerInputController : NetworkedBehaviour, Input.IPlayerActions
{
    public Camera camera;

    Input input;

    PlayerController player;

    public void OnFire(InputAction.CallbackContext context)
    {
        
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        player.LookInput = context.ReadValue<Vector2>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        player.MoveInput = context.ReadValue<Vector2>();
    }

    void Awake()
    {
        player = GetComponent<PlayerController>();
    }

    private void Start()
    {
        if (IsOwner)
        {
            input = new Input();
            input.Player.SetCallbacks(this);
            input.Player.Enable();

            Cursor.lockState = CursorLockMode.Locked;
        }

        camera.gameObject.SetActive(IsOwner);
    }
}
