using System;
using UnityEngine;

public class EventBus 
{
    public event Action<Vector2> OnMovePressed;
    public static event Action OnSpacePressed;
    public static event Action OnLeftMouseButtonPressed;
    public static event Action<bool> OnShiftPressed;
    public static event Action OnFPressed;
    public static event Action<bool> OnLeftMouseButtonPressedDown;
    
    public static event Action<Vector2> OnLookPressed;
    public void TriggerMove(Vector2 data)
    {
        OnMovePressed?.Invoke(data);
    }
    public void TriggerSpace()
    {
        OnSpacePressed?.Invoke();
    }

    public void TriggerShif(bool isPressed)
    {
        OnShiftPressed?.Invoke(isPressed);
    }
    public void TriggerF()
    {
        OnFPressed?.Invoke();
    }
    public void TriggerLeftMouseButton()
    {
        OnLeftMouseButtonPressed?.Invoke();
    }
    public void TriggerLook(Vector2 data)
    {
        OnLookPressed?.Invoke(data);
    }


}
