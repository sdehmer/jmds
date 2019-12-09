using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoHandLeftGrabbable : OVRGrabbable
{

    public Transform handlerTransform;

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);

        this.enabled = false;
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(Vector3.zero, Vector3.zero);
        
        //transform.localPosition = new Vector3(-0.25f, 0, 0);
        transform.localPosition = new Vector3(0, 0, 0);
        transform.rotation = this.handlerTransform.transform.rotation;

        this.enabled = true;
    }
}
