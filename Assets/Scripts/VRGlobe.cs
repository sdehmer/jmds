using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRGlobe : MonoBehaviour
{

    public GameObject earth;
    private AudioSource audioSource;


    
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }
    


    private void OnTriggerEnter(Collider other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject.CompareTag("Hammer"))
        {
            FixedJoint fixedJoint = earth.GetComponent<FixedJoint>();
            fixedJoint.connectedBody = null;

            audioSource.Play();

            Debug.Log("DESTROY");

            Destroy(fixedJoint);
        }
    }
}
