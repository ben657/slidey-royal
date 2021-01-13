using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using MLAPI;

public class PlayerInputController : NetworkedBehaviour, Input.IPlayerActions
{
    Input input;

    PlayerController player;

    public void OnFire(InputAction.CallbackContext context)
    {
        
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (IsOwner)
        {
            Vector2 input = context.ReadValue<Vector2>();
            player.MoveInput = input;
        }
    }

    void Awake()
    {
        input = new Input();
        input.Player.SetCallbacks(this);
        input.Player.Enable();

        player = GetComponent<PlayerController>();
    }
}
