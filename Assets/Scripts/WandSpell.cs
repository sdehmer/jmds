using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WandSpell : MonoBehaviour
{


    public ParticleSystem particle;
    public GameObject objectInViewport;
    public string AREA_COLLIDER_TAG;
    public Light objectLight;
    public List<ParticleSystem> objectParticles = new List<ParticleSystem>();
    public List<AudioSource> objectSounds = new List<AudioSource>();
    public List<UnityEvent> enableEvents = new List<UnityEvent>();
    public List<UnityEvent> disableEvents = new List<UnityEvent>();

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


            if (OVRInput.GetDown(OVRInput.Button.One)) // returns true if the primary button (typically “A”) was pressed this frame.
            {
                if (objectLight.isActiveAndEnabled)
                {
                    objectLight.enabled = false;

                    foreach (ParticleSystem ps in objectParticles)
                    {
                        ps.gameObject.SetActive(false);
                    }

                    foreach (AudioSource audioSource in objectSounds)
                    {
                        audioSource.enabled = false;
                    }

                    foreach (UnityEvent enableEvent in enableEvents)
                    {
                        enableEvent.Invoke();
                    }
                }
                else
                {
                    objectLight.enabled = true;

                    foreach (ParticleSystem ps in objectParticles)
                    {
                        ps.gameObject.SetActive(true);
                    }

                    foreach (AudioSource audioSource in objectSounds)
                    {
                        audioSource.enabled = true;
                    }

                    foreach (UnityEvent disableEvent in disableEvents)
                    {
                        disableEvent.Invoke();
                    }

                }
            }

        }
    }

}
