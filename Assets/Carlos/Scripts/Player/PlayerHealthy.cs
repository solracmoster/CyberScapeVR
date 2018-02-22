using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayerHealthy : MonoBehaviour {

	// Use this for initialization
	public int health = 3;
     
	void Start () {
		PlayerPrefs.SetInt("Health", health);
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerPrefs.GetInt("Health") <= 0)
        {
            //reload the scene
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene("Retry1");

        }

       
    }
    

			void OnCollisionEnter (Collision collision)
	{
       

        if (collision.gameObject.tag == "Enemy") {
			PlayerPrefs.SetInt ("Health", PlayerPrefs.GetInt ("Health") - 1);
            Soundmanagerscript.PlaySound("PHurt");
        }

		
		if (collision.gameObject.tag == "lazer") {
			PlayerPrefs.SetInt ("Health", PlayerPrefs.GetInt ("Health") - 1);
            //Soundmanagerscript.PlaySound("Hurt");
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HP"))
        {
            PlayerPrefs.SetInt("Health", PlayerPrefs.GetInt("Health") + 1);
            Soundmanagerscript.PlaySound("HP");
        }
    }

}