using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRDoorRightZ : MonoBehaviour
{


    public float START_Z_ROTATION_POS = 359.0f;

    public float END_Z_ROTATION_POS = 220.0f;
    



    // Start is called before the first frame update
    void Start()
    {
        Vector3 currentRotation =  this.transform.localEulerAngles;
        this.transform.localRotation = Quaternion.Euler(currentRotation.x, currentRotation.y, START_Z_ROTATION_POS - 1);
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidbody = this.GetComponent<Rigidbody>();

        if (this.transform.localEulerAngles.z > START_Z_ROTATION_POS || this.transform.localEulerAngles.z < 5)
        {
            Vector3 currentRotation = this.transform.localEulerAngles;
            this.transform.localRotation = Quaternion.Euler(currentRotation.x, currentRotation.y, START_Z_ROTATION_POS - 1);
            
            rigidbody.isKinematic = true;
            rigidbody.velocity = Vector3.zero;
        }
        else if (this.transform.localEulerAngles.z < END_Z_ROTATION_POS)
        {
            Vector3 currentRotation = this.transform.localEulerAngles;
            this.transform.localRotation = Quaternion.Euler(currentRotation.x, currentRotation.y, END_Z_ROTATION_POS + 1);

            rigidbody.isKinematic = true;
            rigidbody.velocity = Vector3.zero;
        }

        rigidbody.isKinematic = false;
    }
}
