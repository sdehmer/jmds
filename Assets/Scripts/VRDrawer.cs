using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRDrawer : MonoBehaviour
{

    public float START_Z_POS = 0.42f;


    ConfigurableJoint cj; 


    // Start is called before the first frame update
    void Start()
    {
        // Set Drawer to Start-Position (closed in cupboard)
        Vector3 currentPos = this.transform.position;
        GetComponent<Transform>().localPosition =  new Vector3(currentPos.x, currentPos.y, START_Z_POS);


        cj = GetComponent<ConfigurableJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(this.cj.transform);
    }
}
