using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMove : MonoBehaviour
{
    public bool move;
    public float speed = 0.015f;
    private Vector3 startPos;


    public bool Move
    {
        get
        {
            return move;
        }
        set
        {
            move = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Move = false;
        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Move)
        {
            transform.Translate(0f, speed, 0f);

            if(transform.position.y > 23)
            {
                transform.position = startPos;
            }
        }
    }
}
