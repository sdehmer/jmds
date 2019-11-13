using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoHandRightGrabbable : OVRGrabbable
{

    public Transform handlerTransform;

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(Vector3.zero, Vector3.zero);

        //transform.position = this.handlerTransform.transform.position;
        transform.localPosition = new Vector3(0.25f, 0, 0);
        transform.rotation = this.handlerTransform.transform.rotation;
    }
}
