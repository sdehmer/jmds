using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLever : MonoBehaviour
{

    public float START_Z_POS = -4.29f;

    public float END_Z_POS = -8.81f;



    // Start is called before the first frame update
    void Start()
    {
        Vector3 currentPos = this.transform.localPosition;
        this.transform.localPosition = new Vector3(currentPos.x, currentPos.y, START_Z_POS + 0.001f);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.localPosition.z >= START_Z_POS)
        {
            Vector3 currentPos = this.transform.localPosition;
            this.transform.localPosition = new Vector3(currentPos.x, currentPos.y, START_Z_POS - 0.001f);
        }
        else if (this.transform.localPosition.z <= END_Z_POS)
        {
            Vector3 currentPos = this.transform.localPosition;
            this.transform.localPosition = new Vector3(currentPos.x, currentPos.y, END_Z_POS + 0.001f);
        }

        if (this.transform.localPosition.z >= START_Z_POS - 0.5)
        {
            Debug.Log("Disabled");
        }
        else if (this.transform.localPosition.z <= END_Z_POS + 0.5) 
        {
            Debug.Log("Enabled");
        }
    }
}
