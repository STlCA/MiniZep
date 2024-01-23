using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TopDownCharacterController : MonoBehaviour
{
    public delegate void OnMoveDel(Vector2 direction);
    public OnMoveDel OnMoveEvent;

    public delegate void OnLookDel(Vector2 direction);
    public OnLookDel OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
        
    }
}
