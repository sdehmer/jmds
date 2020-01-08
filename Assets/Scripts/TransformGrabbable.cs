using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformGrabbable : OVRGrabbable
{

    public Vector3 offsetPosition;
    public Vector3 offsetRotation;

    

    // Update is called once per frame
    void Update()
    {
        
    }


    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);

        this.transform.localPosition += offsetPosition;
        this.transform.localEulerAngles += offsetRotation;
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
    }
}
