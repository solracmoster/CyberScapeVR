using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class displaymytext1 : MonoBehaviour {

	// Use this for initialization
	int coin;
	void Start () {
		coin = PlayerPrefs.GetInt ("Coin");
	}
	
	// Update is called once per frame
	void Update () {
		coin = PlayerPrefs.GetInt ("Coin");
		GetComponent<Text> ().text = "" + coin;
	}
}
