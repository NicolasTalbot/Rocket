using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    private Rigidbody rocketRigidBody;
    [SerializeField] public float forceUp = 70;
    [SerializeField] public float forceSides = 5;
    // Use this for initialization
    void Start () {
        rocketRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Jump") > 0)
        {
            rocketRigidBody.AddRelativeForce(new Vector3(0, forceUp, 0));
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            rocketRigidBody.AddForceAtPosition(new Vector3(-forceSides, 0, 0), new Vector3(0, 0, 0));
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rocketRigidBody.AddForceAtPosition(new Vector3(forceSides, 0, 0), new Vector3(0, 0, 0));
        }

    }
}
