using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCasket : MonoBehaviour
{

    public GameObject CasketKey;

    public HingeJoint CasketLid;

    public GameObject LidHandler;


    // Start is called before the first frame update
    void Start()
    {
        CasketLid.useLimits = true;

        LidHandler.SetActive(false);

        /*
        JointLimits limit = new JointLimits();
        limit.min = 0f;
        limit.max = 170f;
        
        CasketLid.limits = limit;
        */

        JointLimits limit = new JointLimits();
        limit.min = 0f;
        limit.max = 150f;

        CasketLid.limits = limit;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject.CompareTag("Casket_Key"))
        {
            CasketKey.SetActive(true);

            OVRGrabbable grabbable = gameObject.GetComponent<OVRGrabbable>();
            MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();

            renderer.enabled = false;
            grabbable.enabled = false;

            grabbable.grabbedBy.ForceRelease(grabbable);
            
            gameObject.SetActive(false);
            Destroy(gameObject, 10.0f);

            LidHandler.SetActive(true);
        }
    }

}
