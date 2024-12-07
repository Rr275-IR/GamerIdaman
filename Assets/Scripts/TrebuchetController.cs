using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrebuchetController : MonoBehaviour
{
    public Rigidbody weight;
    public GameObject cannonball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            weight.isKinematic = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            HingeJoint hingetodestroy;
            hingetodestroy = cannonball.GetComponent<HingeJoint>();
            Destroy(hingetodestroy);
        }
    }

}
