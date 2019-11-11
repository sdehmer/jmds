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

        this.transform.localRotation = Quaternion.Euler(START_X_ROTATION_POS - 1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Level: " + this.transform.localEulerAngles.x);

        if (this.transform.localEulerAngles.x >= START_X_ROTATION_POS)
        {
            Vector3 currentRotation = this.transform.localEulerAngles;
            this.transform.localRotation = Quaternion.Euler(START_X_ROTATION_POS - 1, 0, 0);
        }
        else if (this.transform.localEulerAngles.x <= END_X_ROTATION_POS)
        {
            Vector3 currentRotation = this.transform.localEulerAngles;
            this.transform.localRotation = Quaternion.Euler(END_X_ROTATION_POS + 1, 0, 0);
        }
    }
}
