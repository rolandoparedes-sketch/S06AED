using Sirenix.OdinInspector;
using System;
using Unity.VisualScripting;
using UnityEngine;

public class WindowManager : MyStack<Window>
{
    public Action<Window> OnElementAdded;
    public Action<Window> OnElementRemoved;



    public override void Push(Window value)
    {
        base.Push(value);
        OnElementAdded?.Invoke(Peek());

    }

    public override Window Pop()
    {
        if (Count == 0) return null;

        Window top = Peek();

        if (top != null && top.window.activeSelf)
        {
            OnElementRemoved?.Invoke(top);
        }

        if (Count == 0) return null;
        return base.Pop();
    }




}
