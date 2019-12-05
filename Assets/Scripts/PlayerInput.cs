using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{


    public OVRPlayerController controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    

    // Update is called once per frame
    void Update()
    {
        float leftTrigger = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.LTouch);
        float rightTrigger = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger, OVRInput.Controller.RTouch);
        

        if (leftTrigger > 0.2f || rightTrigger > 0.2f)
        {
            Debug.Log("Apfelmus!");
            controller.Jump();
        }
    }

    
}
