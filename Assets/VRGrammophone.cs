using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRGrammophone : MonoBehaviour
{

    public GameObject noteJupiter;



    private void OnTriggerEnter(Collider other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject.CompareTag("Note_Jupiter"))
        {
            noteJupiter.GetComponent<MeshRenderer>().enabled = true;

            AudioSource audioSource = this.GetComponent<AudioSource>();
            if(audioSource != null)
            {
                audioSource.Play();
            }


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
