using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InPlayerViewport : MonoBehaviour
{

    public bool isVisible;

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
