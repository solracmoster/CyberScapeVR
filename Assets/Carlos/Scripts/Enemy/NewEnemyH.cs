using UnityEngine;
using System.Collections;

public class NewEnemyH : MonoBehaviour {

	// Use this for initialization
	private int healthe = 15;
	void Start () {
		PlayerPrefs.SetInt("Healthe", healthe);
	}
	
	// Update is called once per frame
	void Update () {
				if(PlayerPrefs.GetInt ("Healthe") <=0) {
            Destroy(this.gameObject);

        }
       
    }
			void OnCollisionEnter (Collision collision)
	{

		if (collision.gameObject.tag == "Bat") {
			PlayerPrefs.SetInt ("Healthe", PlayerPrefs.GetInt ("Healthe") - 5);
            Soundmanagerscript.PlaySound("PHurt");
        }

		
		if (collision.gameObject.tag == "Glove") {
			PlayerPrefs.SetInt ("Healthe", PlayerPrefs.GetInt ("Healthe") - 2);
            Soundmanagerscript.PlaySound("punch");
        }

        
    }
   
}