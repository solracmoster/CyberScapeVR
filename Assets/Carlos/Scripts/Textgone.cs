using UnityEngine;
using System.Collections;

public class Textgone : MonoBehaviour {

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



	

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("player"))
            {
                health--;
            }
        }
}