using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class displaymytext : MonoBehaviour {

	// Use this for initialization
	int health;
	void Start () {
		health = PlayerPrefs.GetInt ("Health");
	}
	
	// Update is called once per frame
	void Update () {
		health = PlayerPrefs.GetInt ("Health");
		GetComponent<Text> ().text = "" + health;
	}
}
