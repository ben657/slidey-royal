using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using MLAPI;

public class PlayerInputController : NetworkedBehaviour, PlayerInput.IPlayerActions
{
    public Camera camera;

    PlayerInput input;

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
        transform.position = MapManager.Instance.GetSpawnPoint();
    }

    private void Start()
    {
        if (IsOwner)
        {
            input = new PlayerInput();
            input.Player.SetCallbacks(this);
            input.Player.Enable();

            Cursor.lockState = CursorLockMode.Locked;
        }

        camera.gameObject.SetActive(IsOwner);
    }
}
