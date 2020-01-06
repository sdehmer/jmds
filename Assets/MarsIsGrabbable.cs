using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarsIsGrabbable : MonoBehaviour
{
    
    private bool inArea = true;

    private void OnTriggerEnter(Collider other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject.CompareTag("Fireplace"))
        {
            inArea = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject.CompareTag("Fireplace"))
        {
            inArea = false;
        }
    }

    public void activateObject()
    {
        this.gameObject.SetActive(true);
    }

    public void disableObject()
    {
        if(inArea)
        {
            this.gameObject.SetActive(false);
        }
    }

}
