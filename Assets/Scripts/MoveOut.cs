using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOut : MonoBehaviour
{
    private bool moveActive = false;

    public bool MoveActive { get => moveActive; set => moveActive = value; }

    // Adjust the speed for the application.
    public float speed = 1.0f;

    // The position.
    public Transform target;
    
    Shader shaderDefault;
    Shader shaderHighlight;


    private SphereCollider sphereCollider;


    private void Start()
    {
        sphereCollider = this.GetComponent<SphereCollider>();
        shaderDefault = this.GetComponent<Renderer>().material.shader;
        shaderHighlight = Shader.Find("Custom/Silhouetted Diffuse");
    }

    void Update()
    {
        if (MoveActive)
        {
            sphereCollider.enabled = false;
            this.GetComponent<Rigidbody>().useGravity = false;
            this.GetComponent<Renderer>().material.shader = shaderHighlight;
            // Move our position a step closer to the target.
            float step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            // Check if the position of the cube and sphere are approximately equal.
            if (Vector3.Distance(transform.position, target.position) < 0.1f)
            {
                sphereCollider.enabled = true;
                this.GetComponent<Renderer>().material.shader = shaderDefault;
                this.GetComponent<Rigidbody>().useGravity = true;
                this.MoveActive = false;
                this.enabled = false;
            }
        }
    }
}
