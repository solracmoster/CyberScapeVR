﻿using UnityEngine;
using System.Collections;

public class KeyHealth : MonoBehaviour {

	public int health = 1;


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
		if (collision.gameObject.name == "Door"){
			//when the player runs into an enemy reduce the players health
			health--;
           
        }
	}
}