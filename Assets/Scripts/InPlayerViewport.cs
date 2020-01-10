using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InPlayerViewport : MonoBehaviour
{

    private bool isVisible;

    public bool IsVisible
    {
        get
        {
            Renderer renderer = GetComponent<Renderer>();
            return (renderer.isVisible || isVisible);
        }
        
    }


    // Disable the behaviour when it becomes invisible...
    void OnBecameInvisible()
    {
        isVisible = false;
    }

    // ...and enable it again when it becomes visible.
    void OnBecameVisible()
    {
        isVisible = true;
    }
}
