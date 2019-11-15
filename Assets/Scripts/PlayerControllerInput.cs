using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerInput : MonoBehaviour
{

    public OVRGrabbable wand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(OVRInput.GetDown(OVRInput.Button.One) && wand.isGrabbed) // returns true if the primary button (typically “A”) was pressed this frame.
        {
            Debug.Log("Apfelmus!");
        }
        else if(OVRInput.GetDown(OVRInput.Button.Three) && wand.isGrabbed) // returns true if the primary button (typically “X”) was pressed this frame.
        {
            Debug.Log("Birnenmus!");
        }
    }
}
