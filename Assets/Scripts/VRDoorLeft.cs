using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRDoorLeft : MonoBehaviour
{


    public float START_Y_ROTATION_POS = 1.0f;

    public float END_Y_ROTATION_POS = 140.0f;
    



    // Start is called before the first frame update
    void Start()
    {
        Vector3 currentRotation =  this.transform.localEulerAngles;
        this.transform.localRotation = Quaternion.Euler(currentRotation.x, START_Y_ROTATION_POS + 0.5f, currentRotation.z);
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidbody = this.GetComponent<Rigidbody>();

        if (this.transform.localEulerAngles.y < START_Y_ROTATION_POS || this.transform.localEulerAngles.y > 355)
        {
            Vector3 currentRotation = this.transform.localEulerAngles;
            this.transform.localRotation = Quaternion.Euler(currentRotation.x, START_Y_ROTATION_POS + 0.5f, currentRotation.z);
            
            rigidbody.isKinematic = true;
            rigidbody.velocity = Vector3.zero;

        }
        else if (this.transform.localEulerAngles.y > END_Y_ROTATION_POS)
        {
            Vector3 currentRotation = this.transform.localEulerAngles;
            this.transform.localRotation = Quaternion.Euler(currentRotation.x, END_Y_ROTATION_POS - 0.5f, currentRotation.z);
            
            rigidbody.isKinematic = true;
            rigidbody.velocity = Vector3.zero;
        }

        rigidbody.isKinematic = false;
    }
}
