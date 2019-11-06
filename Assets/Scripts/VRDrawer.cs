using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRDrawer : MonoBehaviour
{

    
    public float START_Z_POS = 0.42f;

    public float END_Z_POS = 0.7494f;



    // Start is called before the first frame update
    void Start()
    {
        // Set Drawer to Start-Position (closed in cupboard)
        Vector3 currentPos = this.transform.localPosition;
        
        this.transform.localPosition = new Vector3(currentPos.x, currentPos.y, START_Z_POS);
        //GetComponent<Transform>().localPosition = new Vector3(currentPos.x, currentPos.y, START_Z_POS);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.localPosition.z <= START_Z_POS)
        {
            Vector3 currentPos = this.transform.localPosition;
            this.transform.localPosition = new Vector3(currentPos.x, currentPos.y, START_Z_POS + 0.001f);
        }
        else if (this.transform.localPosition.z >= END_Z_POS)
        {
            Vector3 currentPos = this.transform.localPosition;
            this.transform.localPosition = new Vector3(currentPos.x, currentPos.y, END_Z_POS - 0.001f);
        }
    }
}
