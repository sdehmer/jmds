using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRChandelier : MonoBehaviour
{

    public GameObject planetVenus;
    public GameObject planetMercury;
    public GameObject planetEarth;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter(Collider other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject.CompareTag("Planet_Venus"))
        {
            planetVenus.SetActive(true);

            UngrabbAndDestroy(gameObject);
        } 
        else if (gameObject.CompareTag("Planet_Mercury"))
        {
            planetMercury.SetActive(true);

            UngrabbAndDestroy(gameObject);
        }
        else if (gameObject.CompareTag("Planet_Earth"))
        {
            planetEarth.SetActive(true);

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
