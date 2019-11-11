using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoHandGrabbable : OVRGrabbable
{


    private OVRGrabber hand1 = null;
    private OVRGrabber hand2 = null;

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        if (hand1 == null)
        {
            hand1 = hand;
        }
        else
        {
            hand2 = hand;
        }

        if (hand2 != null)
        {
            base.GrabBegin(hand, grabPoint);
        }
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        if (hand2 != null)
        {
            hand2 = null;
        }
        else
        {
            hand1 = null;
        }

        if (hand2 == null)
        {
            base.GrabEnd(linearVelocity, angularVelocity);
        }
    }

}
