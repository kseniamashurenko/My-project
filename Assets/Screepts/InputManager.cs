using System;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class InputManager : MonoBehaviour
{
    private EventBus _eventBus;
    //public static event Action OnSpacePressed;
    //public static event Action OnLeftMouseButtonPressed;
    //public static event Action<bool> OnShiftPressed;
    //public static event Action OnFPressed;
    //public static event Action<bool> OnLeftMouseButtonPressedDown;
    //public static event Action<Vector2> OnMovementPressed;
    //public static event Action<Vector2> OnLookPressed;

    public void Initialized(EventBus eventBus )
    {
        _eventBus = eventBus;
    }


    public void OnSpacePressede(CallbackContext context)
    {
        if (context.performed)
        {
            _eventBus.TriggerSpace();
        }
    }
    public void OnLeftMouseButtonPresse(CallbackContext context)
    {
        if (context.performed)
        {
            _eventBus.TriggerLeftMouseButton();
        }
       
    }
    public void OnFPresse(CallbackContext context)
    {
        if (context.started)
        {
            _eventBus.TriggerF();
        }
    }

    public void OnMovePressede(CallbackContext context)
    {
        if (context.performed)
        {
            Vector2 move = context.ReadValue<Vector2>();
            _eventBus.TriggerMove(move);
        }
        if (context.canceled)
        {
            _eventBus.TriggerMove(Vector2.zero);
        }
    }
    public void OnLookPressede(CallbackContext context)
    {
        if (context.performed)
        {
            Vector2 look = context.ReadValue<Vector2>();
            _eventBus.TriggerLook(look);
        }
        if (context.canceled)
        {
            _eventBus.TriggerLook(Vector2.zero);
        }
    }
    public void OnShiftPressede(CallbackContext context)
    {
        if (context.started)
        {
            _eventBus.TriggerShif(true);
        }
        else if (context.canceled)
        {
           _eventBus.TriggerShif(false);
        }

    }
}
