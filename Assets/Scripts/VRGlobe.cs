using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRGlobe : MonoBehaviour
{

    public GameObject earth;
    public GameObject globe;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject.CompareTag("Hammer"))
        {
            FixedJoint fixedJoint = earth.GetComponent<FixedJoint>();
            fixedJoint.connectedBody = null;

            Destroy(fixedJoint, 10.0f);
        }
    }
}
