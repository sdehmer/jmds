using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPlanet : MonoBehaviour
{

    public string TAG_Planet;


    private void OnTriggerEnter(Collider other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject.CompareTag(TAG_Planet))
        {
            this.GetComponent<MeshRenderer>().enabled = true;

            UngrabbAndDestroy(gameObject);
        }
    }


    private void UngrabbAndDestroy(GameObject gameObject)
    {
        OVRGrabbable grabbable = gameObject.GetComponent<OVRGrabbable>();
        MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();

        renderer.enabled = false;
        grabbable.enabled = false;

        grabbable.grabbedBy.ForceRelease(grabbable);

        gameObject.SetActive(false);
        Destroy(gameObject, 10.0f);
    }
}
