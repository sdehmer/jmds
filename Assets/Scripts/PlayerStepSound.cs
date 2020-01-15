using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStepSound : MonoBehaviour
{

    public AudioSource audioClipFloor;
    public AudioSource audioClipRug;

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

        Debug.Log(moving.magnitude);

        if (moving.magnitude > 0)
        {
            if (inArea)
            {
                if (audioClipFloor.isPlaying)
                {
                    audioClipFloor.Stop();
                }
                audioClipRug.Play();
            }
            else if (!inArea)
            {
                if (audioClipRug.isPlaying)
                {
                    audioClipRug.Stop();
                }
                audioClipFloor.Play();
            }
        }
        else
        {
            audioClipRug.Stop();
            audioClipFloor.Stop();
        }
            
    }

    
}
