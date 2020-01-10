using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRWand : MonoBehaviour
{

    public ParticleSystem particleFirespace;
    public GameObject fireplace;

    private bool inArea = false;


    private void OnTriggerEnter(Collider other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject.CompareTag("Fireplace_Wand"))
        {
            Debug.Log("In Area");
            inArea = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject.CompareTag("Fireplace_Wand"))
        {
            Debug.Log("Out Area");
            inArea = false;
        }
    }

    public void Update()
    {
        OVRGrabbable grabbed = this.GetComponent<OVRGrabbable>();

        if (inArea && grabbed.isGrabbed)
        {
            InPlayerViewport viewport = fireplace.GetComponent<InPlayerViewport>();

            if (viewport.IsVisible)
            {
                Debug.Log("Play effect");
                particleFirespace.Play();
            }
            else
            {
                particleFirespace.Stop();
            }
        }
        else
        {
            particleFirespace.Stop();
        }
    }

}
