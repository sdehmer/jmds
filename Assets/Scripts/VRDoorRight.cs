using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRDoorRight : MonoBehaviour
{


    public float START_Y_ROTATION_POS = 359.0f;

    public float END_Y_ROTATION_POS = 220.0f;
    



    // Start is called before the first frame update
    void Start()
    {
        //START_Y_ROTATION_POS = 359;
        //END_Y_ROTATION_POS = 220;

        Vector3 currentRotation =  this.transform.localEulerAngles;
        this.transform.localRotation = Quaternion.Euler(currentRotation.x, START_Y_ROTATION_POS - 1, currentRotation.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.localEulerAngles.y > START_Y_ROTATION_POS || this.transform.localEulerAngles.y < 5)
        {
            Vector3 currentRotation = this.transform.localEulerAngles;
            this.transform.localRotation = Quaternion.Euler(currentRotation.x, START_Y_ROTATION_POS - 1, currentRotation.z);
        }
        else if (this.transform.localEulerAngles.y < END_Y_ROTATION_POS)
        {
            Vector3 currentRotation = this.transform.localEulerAngles;
            this.transform.localRotation = Quaternion.Euler(currentRotation.x, END_Y_ROTATION_POS + 1, currentRotation.z);
        }


        /*
        if (this.transform.localEulerAngles.y < START_Y_ROTATION_POS && this.transform.localEulerAngles.y > END_Y_ROTATION_POS)
        {
            Debug.Log("In Area");
        }
        else if (this.transform.localEulerAngles.y > START_Y_ROTATION_POS || this.transform.localEulerAngles.y < 5)
        {
            Debug.Log("TOO CLOSED");
            Vector3 currentRotation = this.transform.localEulerAngles;
            this.transform.localEulerAngles = new Vector3(currentRotation.x, START_Y_ROTATION_POS, currentRotation.z);
            Debug.Log("SET TO: " + START_Y_ROTATION_POS);
        }
        else if (this.transform.localEulerAngles.y < END_Y_ROTATION_POS)
        {
            Debug.Log("TOO OPENED");
            Vector3 currentRotation = this.transform.localEulerAngles;
            this.transform.localEulerAngles = new Vector3(currentRotation.x, END_Y_ROTATION_POS, currentRotation.z);
            Debug.Log("SET TO: " + END_Y_ROTATION_POS);
        }
        */
    }
}
