using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrebuchetController : MonoBehaviour
{
    public Rigidbody weight;
    public GameObject cannonball;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            weight.isKinematic = true;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            HingeJoint hingetodestroy;
            hingetodestroy = cannonball.GetComponent<HingeJoint>();
            Destroy(hingetodestroy);
        }
    }

}
