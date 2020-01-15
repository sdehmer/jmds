using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRJail : MonoBehaviour
{

    public bool BarrierActive
    {
        get;
        set;
    }



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

        if (gameObject.CompareTag("Hammer") && BarrierActive)
        {
            foreach(Transform child in this.transform)
            {
                Rigidbody childBody = child.GetComponent<Rigidbody>();

                if(childBody != null)
                {
                    childBody.isKinematic = false;
                }
            }
        }
    }


}
