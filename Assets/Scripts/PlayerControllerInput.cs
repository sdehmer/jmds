using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerInput : MonoBehaviour
{

    public OVRGrabbable wand;

    float scale = 1f;
    
    Vector3 wandScale;
    Vector3 playerScale;
    
    bool scalePlayerLittle = false;
    bool scalePlayerNormal = false;

    volatile bool isScaling = false;



    public Light fireplaceLight;


    public GameObject cameraRig;
    Vector3 cameraRigScale;

    public GameObject leftHand;
    Vector3 leftHandScale;

    public GameObject rightHand;
    Vector3 rightHandScale;



    // Start is called before the first frame update
    void Start()
    {
        playerScale = this.transform.localScale;
        wandScale = wand.transform.localScale;

        cameraRigScale = cameraRig.transform.localScale;
        leftHandScale = leftHand.transform.localScale;
        rightHandScale = rightHand.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.GetDown(OVRInput.Button.One) && wand.isGrabbed) // returns true if the primary button (typically “A”) was pressed this frame.
        {
            if(fireplaceLight.isActiveAndEnabled)
            {
                fireplaceLight.enabled = false;
            }
            else
            {
                fireplaceLight.enabled = true;
            }
        }

        /*
        if(OVRInput.GetDown(OVRInput.Button.One) && wand.isGrabbed && !isScaling) // returns true if the primary button (typically “A”) was pressed this frame.
        {
            Debug.Log("Apfelmus!");
            isScaling = true;
            scalePlayerLittle = true;
        }
        else if (OVRInput.GetDown(OVRInput.Button.Two) && wand.isGrabbed && !isScaling) // returns true if the primary button (typically “A”) was pressed this frame.
        {
            Debug.Log("Apfelmus!");
            isScaling = true;
            scalePlayerNormal = true;
        }
        else if(OVRInput.GetDown(OVRInput.Button.Three) && wand.isGrabbed && !isScaling) // returns true if the primary button (typically “X”) was pressed this frame.
        {
            Debug.Log("Birnenmus!");
            isScaling = true;
            scalePlayerLittle = true;
        }
        else if (OVRInput.GetDown(OVRInput.Button.Two) && wand.isGrabbed && !isScaling) // returns true if the primary button (typically “A”) was pressed this frame.
        {
            Debug.Log("Apfelmus!");
            isScaling = true;
            scalePlayerNormal = true;
        }

       


        if (scalePlayerNormal)
        {
            if (scale > 1)
            {
                scalePlayerNormal = false;
                isScaling = false;
            }
            else
            {
                scale += 0.005f;
                Debug.Log("scale: " + scale);
            }

            //this.transform.localScale = new Vector3(playerScale.x * scale, playerScale.y * scale, playerScale.z * scale);

            cameraRig.transform.localScale = new Vector3(cameraRigScale.x * scale, cameraRigScale.y * scale, cameraRigScale.z * scale);

            leftHand.transform.localScale = new Vector3(leftHandScale.x * scale, leftHandScale.y * scale, leftHandScale.z * scale);
            rightHand.transform.localScale = new Vector3(rightHandScale.x * scale, rightHandScale.y * scale, rightHandScale.z * scale);

            //wand.transform.localScale = new Vector3(wandScale.x * scale, wandScale.y * scale, wandScale.z * scale);
        }

        if (scalePlayerLittle)
        {
            if (scale < 0.2f)
            {
                scalePlayerLittle = false;
                isScaling = false;
            }
            else
            {
                scale -= 0.005f;
                Debug.Log("scale: " + scale);
            }

            //this.transform.localScale = new Vector3(playerScale.x * scale, playerScale.y * scale, playerScale.z * scale);

            cameraRig.transform.localScale = new Vector3(cameraRigScale.x * scale, cameraRigScale.y * scale, cameraRigScale.z * scale);

            leftHand.transform.localScale = new Vector3(leftHandScale.x * scale, leftHandScale.y * scale, leftHandScale.z * scale);
            rightHand.transform.localScale = new Vector3(rightHandScale.x * scale, rightHandScale.y * scale, rightHandScale.z * scale);

            //wand.transform.localScale = new Vector3(wandScale.x * scale, wandScale.y * scale, wandScale.z * scale);
        }
        */

    }
    
    


}
