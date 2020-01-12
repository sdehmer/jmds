using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRJail : MonoBehaviour
{
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
            foreach(Transform child in this.transform)
            {
                FixedJoint fixedJoint = child.GetComponent<FixedJoint>();

                if(fixedJoint != null)
                {
                    fixedJoint.connectedBody = null;
                    Destroy(fixedJoint);
                }
            }
        }
    }


}
