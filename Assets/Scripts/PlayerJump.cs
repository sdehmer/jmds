using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public OVRPlayerController controller;


    
    void Update()
    {
        float leftTrigger = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.LTouch);
        float rightTrigger = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger, OVRInput.Controller.RTouch);

        if (leftTrigger > 0.2f || rightTrigger > 0.2f)
        {
            controller.Jump();
        }
    }
}
