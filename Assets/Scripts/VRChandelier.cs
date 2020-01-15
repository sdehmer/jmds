using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VRChandelier : MonoBehaviour
{


    private int count = 0;


    public UnityEvent rotation;

    

    public void planetAdded()
    {
        ++count;

        Debug.Log(count);

        if (count == 7)
        {
            rotation.Invoke();
        }
    }
    
}
