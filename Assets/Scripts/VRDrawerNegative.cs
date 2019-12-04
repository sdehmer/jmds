using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRDrawerNegative : MonoBehaviour
{

    
    public float START_Z_POS = -20.47519f;

    public float END_Z_POS = -51.94f;



    // Start is called before the first frame update
    void Start()
    {
        // Set Drawer to Start-Position (closed in cupboard)
        Vector3 currentPos = this.transform.localPosition;
        
        this.transform.localPosition = new Vector3(currentPos.x, currentPos.y, START_Z_POS - 0.001f);
        //GetComponent<Transform>().localPosition = new Vector3(currentPos.x, currentPos.y, START_Z_POS);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.localPosition.z >= START_Z_POS)
        {
            Vector3 currentPos = this.transform.localPosition;
            this.transform.localPosition = new Vector3(currentPos.x, currentPos.y, START_Z_POS - 0.001f);
        }
        else if (this.transform.localPosition.z <= END_Z_POS)
        {
            Vector3 currentPos = this.transform.localPosition;
            this.transform.localPosition = new Vector3(currentPos.x, currentPos.y, END_Z_POS + 0.001f);
        }
    }
}
