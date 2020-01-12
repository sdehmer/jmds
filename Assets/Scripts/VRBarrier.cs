using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRBarrier : MonoBehaviour
{

    private MeshRenderer meshRenderer;

    public float duration = 0f;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = this.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    private void OnTriggerEnter(Collider other)
    {
        meshRenderer.enabled = true;
        StartCoroutine(RemoveAfterSeconds(2, meshRenderer));
    }
    

    IEnumerator RemoveAfterSeconds(int seconds, MeshRenderer meshRenderer)
    {
        yield return new WaitForSeconds(2);

        meshRenderer.enabled = false;
    }

}
