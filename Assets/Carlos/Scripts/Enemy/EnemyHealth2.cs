﻿using UnityEngine;
using System.Collections;

public class EnemyHealth2 : MonoBehaviour {

	public int health = 3;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(health <= 0) {
         
            Destroy(this.gameObject);

        }

		}



	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.name == "Bat"){
			
			health--;
           
        }


	}


}