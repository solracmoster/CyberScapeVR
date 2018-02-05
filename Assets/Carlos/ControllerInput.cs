using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour {

    public Transform gunBarrelTransform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
        {
            RaycastGun();

        }
	}

    private void RaycastGun()
    {
        RaycastHit hit;

        if (Physics.Raycast(gunBarrelTransform.position, gunBarrelTransform.forward, out hit))
        {
            if (hit.collider.gameObject.CompareTag("Cube"))
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
