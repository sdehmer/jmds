using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandSpell : MonoBehaviour
{


    public ParticleSystem particle;
    public GameObject objectInViewport;
    public string AREA_COLLIDER_TAG;
    public Light objectLight;
    public List<ParticleSystem> objectParticles = new List<ParticleSystem>();

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

            if (viewport.isVisible)
            {
                particle.Play();
            }


            if (OVRInput.GetDown(OVRInput.Button.One)) // returns true if the primary button (typically “A”) was pressed this frame.
            {
                if (objectLight.isActiveAndEnabled)
                {
                    objectLight.enabled = false;

                    foreach (ParticleSystem ps in objectParticles)
                    {
                        ps.gameObject.SetActive(false);
                    }
                }
                else
                {
                    objectLight.enabled = true;

                    foreach (ParticleSystem ps in objectParticles)
                    {
                        ps.gameObject.SetActive(true);
                    }
                }
            }

        }
    }

}
