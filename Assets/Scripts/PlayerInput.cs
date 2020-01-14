using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public AudioClip audioClipFloor;
    public AudioClip audioClipRuge;

    private AudioSource audioSource;

    void Start()
    {

    }

    private bool inArea = false;


    private void OnTriggerEnter(Collider other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject.CompareTag("Ruge"))
        {
            inArea = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject.CompareTag("Ruge"))
        {
            inArea = false;
        }
    }



    void Update()
    {
        Vector2 moving = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.LTouch);
        
        if(moving.magnitude > 0)
        {
            if(audioSource == null)
            {
                // start moving

                if (inArea)
                {
                    audioSource = new AudioSource();
                    audioSource.clip = audioClipRuge;
                    audioSource.Play();
                }
                else
                {
                    audioSource = new AudioSource();
                    audioSource.clip = audioClipFloor;
                    audioSource.Play();
                }
            }
            else
            {
                if (inArea && audioSource.clip == audioClipFloor)
                {
                    audioSource.Stop();
                    audioSource.clip = audioClipRuge;
                    audioSource.Play();
                }
                else if(!inArea && audioSource.clip == audioClipRuge)
                {
                    audioSource.Stop();
                    audioSource.clip = audioClipFloor;
                    audioSource.Play();
                }
            }
            
        }
        else
        {
            if(audioSource != null)
            {
                audioSource.Stop();
                audioSource = null;
            }
        }
    }

    
}
