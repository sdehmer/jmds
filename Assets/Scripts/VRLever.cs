using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLever : MonoBehaviour
{


    public float START_X_ROTATION_POS = 30.0f;

    public float END_X_ROTATION_POS = -30.0f;
    



    // Start is called before the first frame update
    void Start()
    {
        Vector3 currentRotation =  this.transform.localEulerAngles;

        this.transform.localEulerAngles = new Vector3(START_X_ROTATION_POS, currentRotation.y, currentRotation.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.localEulerAngles.x >= START_X_ROTATION_POS)
        {
            Vector3 currentRotation = this.transform.localEulerAngles;
            this.transform.localEulerAngles = new Vector3(START_X_ROTATION_POS, currentRotation.y, currentRotation.z);
        }
        else if (this.transform.localEulerAngles.x <= END_X_ROTATION_POS)
        {
            Vector3 currentRotation = this.transform.localEulerAngles;
            this.transform.localEulerAngles = new Vector3(END_X_ROTATION_POS, currentRotation.y, currentRotation.z);
        }
    }
}
