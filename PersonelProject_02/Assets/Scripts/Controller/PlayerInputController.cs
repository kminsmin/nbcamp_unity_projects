using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : PlayerEventController
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveDirection = value.Get<Vector2>().normalized;
        CallMoveEvent(moveDirection);
    }

    public void OnLook(InputValue value)
    {
        Vector2 mousePos = value.Get<Vector2>();
        //Debug.Log(mousePos);
        Vector2 worldPos = _camera.ScreenToWorldPoint(mousePos);
        mousePos = (worldPos - (Vector2)transform.position).normalized;
        if (mousePos.magnitude > 0.9f)
            CallLookEvent(mousePos);
        
    }

}
