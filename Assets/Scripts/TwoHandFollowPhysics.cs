using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoHandFollowPhysics : MonoBehaviour
{

    public OVRGrabbable targetLeft;
    public OVRGrabbable targetRight;
    Rigidbody rb;

    Rigidbody parent;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        parent = GetComponent<FixedJoint>().connectedBody;
    }

    // Update is called once per frame
    void Update()
    {
        if (targetLeft.isGrabbed && targetRight.isGrabbed)
        {
            parent.useGravity = false;

            Vector3 middlePos = targetLeft.transform.position + targetRight.transform.position;
            middlePos = middlePos / 2;
            
            rb.MovePosition(middlePos);

            Vector3 rotation = targetLeft.transform.eulerAngles; // + targetRight.transform.eulerAngles;
            //rotation = rotation / 2;

            rb.MoveRotation(Quaternion.Euler(rotation));
        }
        else
        {
            parent.useGravity = true;
        }
    }
}
