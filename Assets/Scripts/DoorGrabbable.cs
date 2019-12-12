using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGrabbable : OVRGrabbable
{

    public Transform handlerTransform;

    public Rigidbody mainObject;

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(Vector3.zero, Vector3.zero);
        
        transform.position = this.handlerTransform.transform.position;
        transform.rotation = this.handlerTransform.transform.rotation;

        //mainObject.isKinematic = true;
        mainObject.velocity = Vector3.zero;
        //mainObject.isKinematic = false;
    }
}
