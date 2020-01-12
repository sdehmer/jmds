using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRChandelier : MonoBehaviour
{


    private int count = 0;

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
            // rotate
        }
    }
}
