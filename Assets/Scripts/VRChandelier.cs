using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VRChandelier : MonoBehaviour
{


    private int count = 0;


    public UnityEvent rotation;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void planetAdded()
    {
        ++count;
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 7)
        {
            rotation.Invoke();
        }
    }
}
