using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WandUnlockSpell : MonoBehaviour
{

    public ParticleSystem particle;
    public GameObject objectInViewport;
    public string AREA_COLLIDER_TAG;
    public List<UnityEvent> enableEvents = new List<UnityEvent>();

    private bool inArea = false;


    private void OnTriggerEnter(Collider other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject.CompareTag(AREA_COLLIDER_TAG))
        {
            inArea = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject.CompareTag(AREA_COLLIDER_TAG))
        {
            inArea = false;
            particle.Stop();
        }
    }




    public void Update()
    {
        OVRGrabbable grabbed = this.GetComponent<OVRGrabbable>();

        if (inArea && grabbed.isGrabbed)
        {
            InPlayerViewport viewport = objectInViewport.GetComponent<InPlayerViewport>();

            if (viewport.IsVisible)
            {
                particle.Play();
            }


            if (OVRInput.GetDown(OVRInput.Button.One))
            {
                foreach (UnityEvent enableEvent in enableEvents)
                {
                    enableEvent.Invoke();
                }

                this.enabled = false;
            }

        }
    }



}
